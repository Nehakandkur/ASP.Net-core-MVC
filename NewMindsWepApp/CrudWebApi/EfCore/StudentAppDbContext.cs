using Microsoft.EntityFrameworkCore;
//using MovieApiWithEF.Models;
using CrudWebApi.Models;

namespace CrudWebApi.EfCore
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {

        }
    }
}