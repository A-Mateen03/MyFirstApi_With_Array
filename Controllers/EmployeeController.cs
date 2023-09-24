using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public string[] employee = { "MATEEN", "ALI", "AHSAN" };

        [HttpGet]
        public string[] GetEmployees()
        {
            return employee;
        }

        [HttpGet("{id}")]
        public string GetEmployeeById(int id)
        {
           
                return employee[id];
            
         }
    }
}
