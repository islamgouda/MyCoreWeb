namespace MyCoreWeb.Model
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
      public List<Employee> Employees { get; set; }
    }
}
