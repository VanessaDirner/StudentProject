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
            department departmentobject = new department();

            _db_context.departments.Add(departmentobject);

            departmentobject.deptID = Guid.NewGuid();
            departmentobject.deptname = createdepartmentDTO.DeptName;
            departmentobject.abbreviation = createdepartmentDTO.Abbreviation;
            departmentobject.createdate = DateTime.Now;
            departmentobject.createdby = createdepartmentDTO.CreatedBy;


            await _db_context.SaveChangesAsync();

            
        }

        public async Task ModifyDepartmentsService(ModifyDepartmentDTO modifydepartmentDTO)
        {
            department? departmentobject = await _db_context.departments.FindAsync(modifydepartmentDTO.modifyDeptID);
            // throw exception so that ID can't be invalid so that return employee can't be null
            if (departmentobject == null)
            {
                throw new Exception("invalid department ID");
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

            if (deletedepartmentDTO == null)
            {
                throw new Exception("invalid department ID");
            }

            _db_context.departments.Remove(department);

            await _db_context.SaveChangesAsync();

        }

    }
}
