using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystems.Model.Entities
{
    internal class Buildings
    {
        public string Name { get; set; }

        public List<Departments> Departments { get; set; }
    }
}
