using Microsoft.EntityFrameworkCore;
using studentprojectapi.GeneratedModels;

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

    }
}
