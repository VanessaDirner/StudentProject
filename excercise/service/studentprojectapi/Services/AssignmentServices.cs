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
            assignment assignmentobject = new assignment();

            // get department info, get employee info

            // check that department and employee exist 

            // check whether they already exist in assignment table

            // map assignment DTO from generated model
            assignmentobject.assignmentID = Guid.NewGuid();
            assignmentobject.createdby = createassignmentDTO.CreatedBy;
            assignmentobject.createdate = DateTime.Now;
            assignmentobject.modifieddate = DateTime.Now;
            assignmentobject.modifiedby = createassignmentDTO.ModifiedBy;

            // get values for person and department id foreign key from tables
          //  assignmentobject.DeptID = createassignmentDTO.DeptName
            //
          //  insert into assignment(assignmentID, personID, deptID, createdate, createdby, modifiedby, modifieddate)
//values(newid(), (select employee.personID from employee where email = 'string'), (select department.deptID from department where department.deptname = 'math'),  getdate() , 'a', 'b', getdate())


            _database_context.assignments.Add(assignmentobject);

            // save changes to database
            await _database_context.SaveChangesAsync();

        }

        // probably don't need to modify an existing assignment
        public async Task ModifyAssignmentAsync(ModifyAssignmentDTO modifyassignmentDTO)
        {
            assignment? assignment = await _database_context.assignments.FindAsync(modifyassignmentDTO.AssignmentID);

            if (assignment == null)
            {
                throw new Exception("invalid assignment ID");
            }

            assignment.assignmentID = modifyassignmentDTO.AssignmentID;
            assignment.modifieddate = DateTime.Now;
            assignment.modifiedby = modifyassignmentDTO.ModifiedBy;
            assignment.personID = modifyassignmentDTO.PersonID;
            assignment.deptID = modifyassignmentDTO.DeptID;

            _database_context.Entry(assignment).State = EntityState.Modified;

            await _database_context.SaveChangesAsync();

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
