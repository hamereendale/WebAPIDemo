using Contracts;
using Entity;
using Microsoft.EntityFrameworkCore;
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

        public async Task<int> Delete(int id)
        {

            if (_dbContext.Employees == null)
            {
                return 0;
            }
            var employee = await _dbContext.Employees.FindAsync(id);
            if (employee == null)
            {
                return 0;
            }

            _dbContext.Employees.Remove(employee);
            _dbContext.SaveChanges();
            return employee.Id;
        }

       
        public async Task<Employee> GetEmployee(int id)
        {
            if (_dbContext.Employees == null)
            {
                return null;
            }
            var employee =await _dbContext.Employees.FindAsync(id);

            if (employee == null)
            {
                return null;
            }

            return employee;
        }

       
        public bool PutEmployee(int id, Employee employee)
        {
            var existing = _dbContext.Employees.Find(id);
            if (id == employee.Id)
            {
                existing.fName = employee.fName;
                existing.lName = employee.lName;
                existing.address = employee.address;
                _dbContext.Employees.Update(existing);
                 _dbContext.SaveChanges();
                return true;
            }
           
             return false;
          
        }


    }
}
