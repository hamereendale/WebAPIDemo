using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IDepartment
    {
        public int Create(Departement departement);
        public List<Departement> GetAll();
        public Task<int> Delete(int id);
        public Task<Departement> GetDepartment(int id);
        public bool PutDepartment(int id, Departement departement);
    }
}
