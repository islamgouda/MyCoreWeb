using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCoreWeb.Model;
using MyCoreWeb.Repository;

namespace MyCoreWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeRepository employeeRepository;
        public EmployeeController(IEmployeeRepository _employeeRepository)
        {
            employeeRepository = _employeeRepository;
        }
        [HttpGet]
        public IActionResult getAll()
        {
            List<Employee> employees=employeeRepository.getAll();
            return Ok(employees);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult getbyID(int id)
        {
            Employee em=employeeRepository.getById(id);
            return Ok(em);
        }
        [HttpPost]
        public IActionResult Add(Employee newEmp)
        {
            if (ModelState.IsValid) {
            employeeRepository.insert(newEmp);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        [HttpPut("{id:int}")]
        public IActionResult update([FromRoute]int id,[FromBody]Employee emp)
        {
            if (ModelState.IsValid) {
                employeeRepository.update(id, emp);
                return StatusCode(StatusCodes.Status200OK,"update Success");
            }
            else
            {
                return BadRequest("data not valid");
            }
            
        }

        [HttpDelete]
        public IActionResult delete(int id)
        {
          employeeRepository.delete(id);
            return StatusCode(StatusCodes.Status200OK, "Delete Success");

        }
    }
}
