using Contracts;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_API_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployee _employeeService;
        public EmployeesController(IEmployee employeeService)
        {
            _employeeService = employeeService;
        }
    [HttpPost]
    public int Create(Employee employee)
        {
            return _employeeService.Create(employee);
        }
    [HttpGet]
    public List<Employee> Get()
        {
            return _employeeService.GetAll();
        }

    [HttpGet("{id}")]
        public Task<Employee> GetById(int id)
        {
            return _employeeService.GetEmployee(id);
        }

    [HttpPut("{id}")]
        public bool PutEmployee(int id, Employee employee)
        {
            return _employeeService.PutEmployee(id, employee);
        }


        [HttpDelete]
    public Task<int> Delete(int id)
        {
            return _employeeService.Delete(id);
        }
    }
}
