using Contracts;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DepartmentRepository : IDepartment
    {
        private readonly EmployeeDbContext _dbContext;
        public DepartmentRepository(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(Departement departement)
        {
            _dbContext.Departements.Add(departement);
            _dbContext.SaveChanges();
            return departement.Id;
        }


       


        public async Task<int> Delete(int id)
        {

            if (_dbContext.Departements == null)
            {
                return 0;
            }
            var departement = await _dbContext.Departements.FindAsync(id);
            if (departement == null)
            {
                return 0;
            }

            _dbContext.Departements.Remove(departement);
            _dbContext.SaveChanges();
            return departement.Id;
        }


        public async Task<Departement> GetDepartment(int id)
        {
            if (_dbContext.Departements == null)
            {
                return null;
            }
            var departement = await _dbContext.Departements.FindAsync(id);

            if (departement == null)
            {
                return null;
            }

            return departement;
        }


        public bool PutDepartment(int id, Departement departement)
        {
            var existing = _dbContext.Departements.Find(id);
            if (id == departement.Id)
            {
                
                existing.name = departement.name;
                
                _dbContext.Departements.Update(existing);
                _dbContext.SaveChanges();
                return true;
            }

            return false;

        }


    }
}

