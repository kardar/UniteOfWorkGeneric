using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystems.Model.GenericEntities;

namespace UniversitySystems.Model.Entities
{
    internal class Teachers : BaseEntity
    {
        public int Salary { get; set; }

        public string Education { get; set; }

        public ICollection<Departments> Departments { get; set; }
    }
}
