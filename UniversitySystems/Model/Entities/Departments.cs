using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystems.Model.Entities
{
    internal class Departments 

    {
        public string Name { get; set; }

        public string HOD { get; set; }

        ICollection<Teachers> Teachers { get; set; }

        ICollection<Students> Students { get; set; }

         
    }
}
