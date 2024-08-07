using Microsoft.EntityFrameworkCore;
using studentprojectapi.GeneratedModels;
using studentprojectapi.Models;

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

            // map assignment DTO from generated model
            assignmentobject.assignmentID = Guid.NewGuid();
            assignmentobject.createdby = createassignmentDTO.CreatedBy;
            assignmentobject.createdate = DateTime.Now;

            _database_context.assignments.Add(assignmentobject);

            // save changes to database
            await _database_context.SaveChangesAsync();

        }

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
