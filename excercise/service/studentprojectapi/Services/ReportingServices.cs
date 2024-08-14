using Microsoft.EntityFrameworkCore;
using studentprojectapi.GeneratedModels;
using studentprojectapi.Models;
using System.Transactions;

namespace studentprojectapi.Services
{
    public class ReportingServices
    {
        private readonly studentprojectContext _database_context;

        public ReportingServices(studentprojectContext databaseContext) { _database_context = databaseContext; }

        // generate a report of employees assigned to departments

        public async Task<List<ReportingDTO>> GetReportAsync()
        {
            /*

            Array result = await (from assignments in _database_context.assignments

                                  join employees in _database_context.employees on assignments.personID equals employees.personID
                                  join departments in _database_context.departments on assignments.deptID equals departments.deptID
                                  select new
                                  {
                                      EmployeeName = $"{employees.firstname} {employees.lastname}",
                                      Department = $"{departments.deptname}"
                                  }
                        ).ToArrayAsync();
            */

            List<ReportingDTO> report = await (from assignments in _database_context.assignments

                                               join employees in _database_context.employees
                                              on assignments.personID equals employees.personID
                                               join departments in _database_context.departments
                                               on assignments.deptID equals departments.deptID
                                               group new { employees, departments } by departments.deptname into g
                                               select new ReportingDTO
                                               {
                                                   EmployeeNames = g.Select(x => x.employees.firstname + " " + x.employees.lastname).ToList(),
                                                   Department = g.Key
                                               }).ToListAsync();
            
            /*
             * 
            List<ReportingDTO> report = await (from assignments in _database_context.assignments

                                               join employees in _database_context.employees 
                                               on assignments.personID equals employees.personID
                                               join departments in _database_context.departments 
                                               on assignments.deptID equals departments.deptID
                                               let Department = departments.deptID
                                               let EmployeeName = $"{employees.firstname} {employees.lastname}"
                                               group EmployeeName by departments.deptname 
                                               //select newGroup

                                  ).ToListAsync();
             */
            // format report so that it's each department, then assigned people
            /*
            var a = (from assignments in _database_context.assignments

                     join employees in _database_context.employees on assignments.personID equals employees.personID
                     join departments in _database_context.departments on assignments.deptID equals departments.deptID
                     let Department = departments.deptID
                     let EmployeeName = $"{employees.firstname} {employees.lastname}"
                     group EmployeeName by departments.deptname
                     
              );*/

            return (report);

        }


    }
}
/*
 * 
select employee.firstname, employee.lastname, department.deptname
FROM assignment
INNER JOIN employee
ON employee.personID = assignment.personID 
INNER JOIN department
ON department.deptID = assignment.deptID
GROUP BY department.deptname, employee.firstname, employee.lastname
ORDER BY deptname ASC
 * */