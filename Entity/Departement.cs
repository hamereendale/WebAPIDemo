﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Departement
    {
        public int id { get; set;}
        public string name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
