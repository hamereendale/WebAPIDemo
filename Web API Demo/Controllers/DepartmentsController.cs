using Contracts;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_API_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartment _departmentService;
        public DepartmentsController(IDepartment departmentService)
        {
            _departmentService = departmentService;
        }
        [HttpPost]
        public int Create(Departement departement)
        {
            return _departmentService.Create(departement);
        }
        [HttpGet]
        public List<Departement> Get()
        {
            return _departmentService.GetAll();
        }

        [HttpGet("{id}")]
        public Task<Departement> GetById(int id)
        {
            return _departmentService.GetDepartment(id);
        }

        [HttpPut("{id}")]
        public bool PutDepartment(int id, Departement departement)
        {
            return _departmentService.PutDepartment(id, departement);
        }


        [HttpDelete]
        public Task<int> Delete(int id)
        {
            return _departmentService.Delete(id);
        }
    }
}

