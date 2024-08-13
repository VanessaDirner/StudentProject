using Microsoft.EntityFrameworkCore;
using studentprojectapi.GeneratedModels;
using studentprojectapi.Models;

namespace studentprojectapi.Services
{
    public class ReportingServices
    {
        private readonly studentprojectContext _database_context;

        public ReportingServices(studentprojectContext databaseContext) { _database_context = databaseContext; }

        // generate a report of employees assigned to departments
        public async Task<Array> GetReportAsync() 
            {
            //  Array assignments = await (from row in _database_context.assignments select row);

            /*   employee employees = new employee();
               department departments = new department();   
               assignment assignment = new assignment();
            */             
            /*
            Array listofemployees = await (from assignments in _database_context.assignments
                                 join employees in _database_context.employees on assignments.personID equals employees.personID
                                 join departments in _database_context.departments on assignments.deptID equals departments.deptID
                                 select employees ).ToArrayAsync();

            var query = from assignments in _database_context.assignments
                        join employees in _database_context.employees on assignments.personID equals employees.personID
                        join departments in _database_context.departments on assignments.deptID equals departments.deptID
                        select new {Department = $"{departments.deptname}", departments.abbreviation, employees.active, EmployeeName = $"{employees.firstname} {employees.lastname}" , employees.phonenumber, employees.email };
            */

            Array result = await (from assignments in _database_context.assignments
                        join employees in _database_context.employees on assignments.personID equals employees.personID
                        join departments in _database_context.departments on assignments.deptID equals departments.deptID
                        select new 
                        { 
                            department = $"{departments.deptname}",
                            departments.abbreviation,
                            employees.active,
                            employeename = $"{employees.firstname} {employees.lastname}",
                            employees.phonenumber,
                            employees.email }
                        ).ToArrayAsync();


            return (result);
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
