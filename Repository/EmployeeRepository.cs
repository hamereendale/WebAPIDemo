using Contracts;
using Entity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeRepository : IEmployee
    {
        private readonly EmployeeDbContext _dbContext;
        public EmployeeRepository(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
            return employee.Id;
        }

        public List<Employee> GetAll()
        {
            return _dbContext.Employees.ToList();
        }
    }
}
