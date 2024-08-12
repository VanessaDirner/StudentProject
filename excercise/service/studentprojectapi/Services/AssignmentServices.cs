using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using studentprojectapi.GeneratedModels;
using studentprojectapi.Models;
using System.Collections.Generic;

namespace studentprojectapi.Services
{
    public class AssignmentServices
    {

        private readonly studentprojectContext _database_context;


        public AssignmentServices(studentprojectContext studenttablecontext) { _database_context = studenttablecontext; }


        // get users assigned to departments from assignments table
        public async Task<List<assignment>> GetAssignmentsAsync()
        {
            List<assignment> ListofAssignments = await (from row in _database_context.assignments select row).ToListAsync();

            return ListofAssignments;   
        }

        // write function to add people to departments
        public async Task AddAssignmentsAsync(CreateAssignmentDTO createassignmentDTO)
        {
            // this will hold the details we'll send to the database
            assignment assignmentobject = new assignment();

            // check that department exists and get ID
            department? departmentobject = await _database_context.departments.FindAsync(createassignmentDTO.DeptID);
            // throw exception so that ID can't be invalid so that return employee can't be null
            if (departmentobject == null)
            {
                throw new Exception("invalid department to assign to");
                
            }

            // check that employee exists and get ID
            employee? employee = await _database_context.employees.FindAsync(createassignmentDTO.PersonID);
            // throw exception so that ID can't be invalid so that return employee can't be null
            if (employee == null)
            {
                throw new Exception("invalid person to assign");
            }

            // if the deptID and personID already exist in a row, then this would be a duplicate request
            if ((assignmentobject.deptID == departmentobject.deptID) && (assignmentobject.personID == employee.personID))
            {
                throw new Exception("Employee is already assigned to this department");
            }
            else // create the assignment object in database
            {

                // map assignment DTO from generated model
                assignmentobject.assignmentID = Guid.NewGuid();
                assignmentobject.deptID = createassignmentDTO.DeptID;
                assignmentobject.personID = createassignmentDTO.PersonID;
                assignmentobject.createdby = createassignmentDTO.CreatedBy;
                assignmentobject.createdate = DateTime.Now;
                assignmentobject.modifieddate = DateTime.Now;
                assignmentobject.modifiedby = createassignmentDTO.ModifiedBy;

                _database_context.assignments.Add(assignmentobject);

                // save changes to database
                await _database_context.SaveChangesAsync();

}
        }



        // write function to remove people from departments

        public async Task DeleteAssignmentAsync(DeleteAssignmentDTO deleteassignmentDTO)
        {
            assignment? assignment = await _database_context.assignments.FindAsync(deleteassignmentDTO.AssignmentID);
            if (assignment == null)
            {
                throw new Exception("invalid assignment ID");
            }

            _database_context.assignments.Remove(assignment);

            await _database_context.SaveChangesAsync(); 
        }



    }
}
