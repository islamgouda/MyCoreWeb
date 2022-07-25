using MyCoreWeb.Model;

namespace MyCoreWeb.Repository
{
    public interface Icourse
    {
        public Course GetCourseById(int id);
        public List<Course> GetAll();
        public void insert(Course course);

    }
}
