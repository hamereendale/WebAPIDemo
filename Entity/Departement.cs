using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Departement
    {
         [Column("departmentId")]
        public int Id { get; set;}
        public string name { get; set; }
        
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
