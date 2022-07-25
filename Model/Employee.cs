using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCoreWeb.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }

        public Course Course { get; set; }

    }
}
