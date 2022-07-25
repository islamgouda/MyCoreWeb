using MyCoreWeb.Model;
using Microsoft.EntityFrameworkCore;
namespace MyCoreWeb.Repository
{
    
    public class CourseRepository : Icourse
    {
        Context context;
        public CourseRepository(Context _context)
        {
            context = _context;
        }
        public List<Course> GetAll()
        {
           return context.Courses.ToList();
        }

        public Course GetCourseById(int id)
        {
            return context.Courses.Include(t=>t.Employees).FirstOrDefault(e => e.Id == id);
        }

        public void insert(Course course)
        {
            context.Courses.Add(course);
        }
    }
}
