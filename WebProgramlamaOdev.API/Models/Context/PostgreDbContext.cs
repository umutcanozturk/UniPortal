

using Microsoft.EntityFrameworkCore;
using WebProgramlamaOdev.Core.Models;

namespace WebProgramlamaOdev.API.Models.Context
{
    public class PostgreDbContext : DbContext
    {
        public PostgreDbContext(DbContextOptions<PostgreDbContext> options) : base(options) { }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Personel> Personel { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<LoginModel> LoginModel { get; set; }
    }
}
