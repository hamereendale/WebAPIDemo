using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Employee
    {
        public int Id { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string address { get; set; }
       
        [ForeignKey(nameof(Departement))]
        public int? departmentId { get; set; }
      
    }
}
