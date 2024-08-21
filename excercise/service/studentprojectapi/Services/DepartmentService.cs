using AutoMapper;
using Microsoft.EntityFrameworkCore;
using studentprojectapi.GeneratedModels;
using studentprojectapi.Models;


namespace studentprojectapi.Services
{
    public class DepartmentService
    {
        private readonly studentprojectContext _db_context;
        private readonly IMapper _mapper;

        public DepartmentService(studentprojectContext context, IMapper mapper) { _db_context = context; _mapper = mapper; }



        public async Task<List<department>> GetDepartmentsAsync()
        {
            List<department> ListofDepartments = await (from row in _db_context.departments select row).ToListAsync();
            Console.WriteLine(_db_context.departments);
            return ListofDepartments;
        }

        public async Task AddDepartmentAsync(DepartmentDTO createdepartmentDTO)
        {
            // create automapper objet of name mapDepartment
            MapperConfiguration mapAddDepartment = new MapperConfiguration(cfg => cfg.CreateMap<department, DepartmentDTO>());

            // check if department is empty
            if ((createdepartmentDTO.DeptName == null) || (createdepartmentDTO.Abbreviation == null))
            {
                throw new Exception("Please provide a department name and abbreviation ");
            }
            // check if department already exists in table
            department? doesdeptexist = await _db_context.departments.SingleOrDefaultAsync(dept => dept.deptname == createdepartmentDTO.DeptName);

            if (doesdeptexist != null)
            {
                throw new Exception("Existing department was found. Please make sure the department name and abbreviation are unique.");
            }


            department adddepartmentobject = _mapper.Map<department>(createdepartmentDTO);

            adddepartmentobject.createdate = DateTime.Now;

            adddepartmentobject.modifieddate = DateTime.Now;
            
            _db_context.departments.Add(adddepartmentobject);

            await _db_context.SaveChangesAsync();

            
        }

        public async Task ModifyDepartmentsService(DepartmentDTO modifydepartmentDTO)
        {
            department? departmentobject = await _db_context.departments.FindAsync(modifydepartmentDTO.DeptID);
            // throw exception so that ID can't be invalid so that return employee can't be null
            if (modifydepartmentDTO.DeptID == null)
            {
                throw new Exception("invalid department ID, please check that the department exists.");
            }
            // check if the department name and abbreviation name already exists
            department? doesdeptnameexist = await _db_context.departments.SingleOrDefaultAsync(dept => dept.deptname == modifydepartmentDTO.DeptName);
            if (modifydepartmentDTO.DeptName == doesdeptnameexist.deptname)
            {
                throw new Exception("DeptName already assigned to a department. Please pick a unique department name, or modify the existing department.");
            }
            department? doesdeptabbrexist = await _db_context.departments.SingleOrDefaultAsync(dept => dept.abbreviation == modifydepartmentDTO.Abbreviation);
            if (modifydepartmentDTO.Abbreviation == doesdeptabbrexist.abbreviation)
            {
                throw new Exception("Abbreviation already assigned to a department. Please pick a unique department abbreviation, or modify the existing department.");
            }

            department modifydepartmentobject = _mapper.Map<department>(modifydepartmentDTO);

            modifydepartmentDTO.ModifiedDate = DateTime.Now;

            _db_context.Entry(modifydepartmentobject).State = EntityState.Modified;

            await _db_context.SaveChangesAsync();
        }

        public async Task DeleteDepartmentService(DeleteDepartmentDTO deletedepartmentDTO)
        {
            department? department = await _db_context.departments.FindAsync(deletedepartmentDTO.DeptID);

            employee? employeeobject = await _db_context.employees.SingleOrDefaultAsync(delemp => delemp.email == deletedepartmentDTO.deletebyEmail);

         
            if (department == null)
            {
                throw new Exception("invalid department ID");
            }
            // if person is assigned to department, cannot delete department

            _db_context.departments.Remove(department);

            await _db_context.SaveChangesAsync();

        }

    }
}
