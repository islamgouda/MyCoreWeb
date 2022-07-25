using Microsoft.EntityFrameworkCore;
namespace MyCoreWeb.Model
{
    public class Context:DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {

        }
        public Context()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source =DESKTOP-JT45RDG;Initial Catalog =ApiDB;Integrated security=true");
        }
        public DbSet<Employee> Employees { get; set; }  
        public DbSet<Course> Courses { get; set; }
    }
}
