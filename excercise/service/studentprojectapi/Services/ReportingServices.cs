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

        }


    }
}
