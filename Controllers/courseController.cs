using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCoreWeb.DDO;
using MyCoreWeb.Repository;
using MyCoreWeb.Model;
namespace MyCoreWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class courseController : ControllerBase
    {
        
        private Icourse courseRepository;
        public courseController(Icourse _courseRepository)
        {
            courseRepository = _courseRepository;
        }
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            Course course=courseRepository.GetCourseById(id);
            courseDDO courseDDO = new courseDDO();
            courseDDO.Id=course.Id;
            courseDDO.Name=course.Name;
            courseDDO.Degree=course.Degree;
            courseDDO.employees=new List<string>();
            foreach(var item in course.Employees)
            {
                courseDDO.employees.Add(item.Name);
            }
            return Ok(courseDDO);
        }
    }
}
