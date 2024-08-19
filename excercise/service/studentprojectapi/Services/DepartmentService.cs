﻿using Microsoft.EntityFrameworkCore;
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

            if (doesdeptexist != null)
            {
                throw new Exception("Existing department was found. Please make sure the department name and abbreviation are unique.");
            }


            // create auto mapper object
        //    var mapper = config.CreateMapper();

            // setup auto mapper for add


         //   department departmentobject = mapper.Map<departmentobject>(createdepartmentDTO);

            
           // OrderDto dto = mapper.Map<OrderDto>(order);

            department departmentobject = new department();
            /*
            departmentobject.deptID = Guid.NewGuid();
            departmentobject.deptname = createdepartmentDTO.DeptName;
            departmentobject.abbreviation = createdepartmentDTO.Abbreviation;
            departmentobject.createdate = DateTime.Now;
            departmentobject.createdby = createdepartmentDTO.CreatedBy;
            departmentobject.modifiedby = createdepartmentDTO.ModifiedBy;
            departmentobject.modifieddate = DateTime.Now;
            */

            _db_context.departments.Add(departmentobject);

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
