using Microsoft.EntityFrameworkCore;
using studentprojectapi.GeneratedModels;
using studentprojectapi.Models;

namespace studentprojectapi.Services
{
    public class DepartmentService
    {
        private readonly studentprojectContext _db_context;

        public DepartmentService(studentprojectContext context) { _db_context = context; }

        public async Task<List<department>> GetDepartmentsAsync()
        {
            List<department> ListofDepartments = await (from row in _db_context.departments select row).ToListAsync();
            Console.WriteLine(_db_context.departments);
            return ListofDepartments;
        }

        public async Task AddDepartmentAsync(CreateDepartmentDTO createdepartmentDTO)
        {
            // check if department is empty
            if ((createdepartmentDTO.DeptName == null) || (createdepartmentDTO.Abbreviation == null))
            {
                throw new Exception("Please provide a department name and abbreviation ");
            }
            // check if department already exists in table
            department? doesdeptexist = await _db_context.departments.SingleOrDefaultAsync(dept => dept.deptname == createdepartmentDTO.DeptName);

            department departmentobject = new department();

            _db_context.departments.Add(departmentobject);

            departmentobject.deptID = Guid.NewGuid();
            departmentobject.deptname = createdepartmentDTO.DeptName;
            departmentobject.abbreviation = createdepartmentDTO.Abbreviation;
            departmentobject.createdate = DateTime.Now;
            departmentobject.createdby = createdepartmentDTO.CreatedBy;
            departmentobject.modifiedby = createdepartmentDTO.ModifiedBy;
            departmentobject.modifieddate = DateTime.Now;


            await _db_context.SaveChangesAsync();

            
        }

        public async Task ModifyDepartmentsService(ModifyDepartmentDTO modifydepartmentDTO)
        {
            department? departmentobject = await _db_context.departments.FindAsync(modifydepartmentDTO.modifyDeptID);
            // throw exception so that ID can't be invalid so that return employee can't be null
            if (modifydepartmentDTO.modifyDeptID == null)
            {
                throw new Exception("invalid department ID, please check that the department exists.");
            }

            departmentobject.deptID = modifydepartmentDTO.modifyDeptID;
            departmentobject.deptname = modifydepartmentDTO.DeptName;
            departmentobject.abbreviation = modifydepartmentDTO.Abbreviation;
            departmentobject.modifieddate = DateTime.Now;
            departmentobject.modifiedby = modifydepartmentDTO.ModifiedBy;


            _db_context.Entry(departmentobject).State = EntityState.Modified;

            await _db_context.SaveChangesAsync();
        }

        public async Task DeleteDepartmentService(DeleteDepartmentDTO deletedepartmentDTO)
        {
            department? department = await _db_context.departments.FindAsync(deletedepartmentDTO.DeptID);

            employee? employeeobject = await _db_context.employees.SingleOrDefaultAsync(delemp => delemp.email == department.DeleteByEmail);

            

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
