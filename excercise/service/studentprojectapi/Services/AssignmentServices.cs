using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using studentprojectapi.GeneratedModels;
using studentprojectapi.Models;
using System.Collections.Generic;
using System.Linq;

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
            else if (employee.active == false) // inactive people should not be available for selection
            {
                throw new Exception("Cannot assign and inactive employee to department");
            }

            // if the deptID and personID already exist in an assignment row, then this would be a duplicate request

            Guid personID = createassignmentDTO.PersonID;
            Guid deptID = createassignmentDTO.DeptID;
           

            // check for dept and person ID


            List<assignment> doesassignmentexist = await  (from row in _database_context.assignments
                                         where row.personID.Equals(personID)
                                         && row.deptID == deptID
                                         select row).ToListAsync();


            // if we get a column back then there's already an assignment
            bool isempty = !doesassignmentexist.Any();

            if ((isempty))
            {
                Console.WriteLine($"{doesassignmentexist} is null ");

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
            else
                throw new Exception($"Employee is already assigned to this department, check for assignment {doesassignmentexist}");
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
