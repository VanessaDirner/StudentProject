using Microsoft.EntityFrameworkCore;
using studentprojectapi.GeneratedModels;

namespace studentprojectapi.Services
{
    public class DepartmentService
    {
        private readonly studentprojectContext _database_context;

        public DepartmentService(studentprojectContext context) { _database_context = context; }

        public async Task<List<department>> GetDepartmentsAsync()
        {
            List<employee> ListofDepartments = await (from row in _database_context.departments select row).ToListAsync();

            return ListofDepartments;
        }
    }
}
