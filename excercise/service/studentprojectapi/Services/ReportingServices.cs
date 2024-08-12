using Microsoft.EntityFrameworkCore;
using studentprojectapi.GeneratedModels;
using studentprojectapi.Models;

namespace studentprojectapi.Services
{
    public class ReportingServices
    {
        private readonly studentprojectContext _database_context;

        public ReportingServices(studentprojectContext databaseContext) { _database_context = databaseContext; }

        public async Task<Array> GetReportAsync() 
            {
            //  Array assignments = await (from row in _database_context.assignments select row);

            /*   employee employees = new employee();
               department departments = new department();   
               assignment assignment = new assignment();
            */

            var list = new List<string> { };

            var 

            List<employee> Listofemployees = await (from assignments in _database_context.assignments
                                 join employees in _database_context.employees on assignments.personID equals employees.personID
                                 join departments in _database_context.departments on assignments.deptID equals departments.deptID
                                 select  assignments).ToListAsync;


                               /*
                               select new array
                               {
                                   Name = $"{employees.firstname} {employees.lastname}",
                                   Phone = employees.phonenumber,
                                   DepartmentName = departments.deptname,
                                   DepartmentAbbreviation = departments.abbreviation
                               }       */                                


            return (0);
            /*
             * select employee.firstname, employee.lastname, employee.phonenumber, employee.email, department.deptname, department.abbreviation
                FROM assignment
                INNER JOIN employee
                ON employee.personID = assignment.personID 
                INNER JOIN department
                ON department.deptID = assignment.deptID
             * 
             */
        }


    }
}
