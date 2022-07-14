using WebProgramlamaOdev.API.Models.Context;
using WebProgramlamaOdev.Core.Interfaces;
using WebProgramlamaOdev.Core.Models;

namespace WebProgramlamaOdev.API.Repository
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(PostgreDbContext dbContext) : base(dbContext)
        {
        }
    }
}
