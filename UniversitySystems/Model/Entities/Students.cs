using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystems.Model.GenericEntities;

namespace UniversitySystems.Model.Entities
{
    internal class Students : BaseEntity
    {
        public double Cgpa { get; set; }

        public string Samester { get; set; }

        public Departments Departments { get; set; }

        public override string ToString()
        {
            return $"{Name},{Id},{Age},{Email},{Address},{Cgpa},{Samester}";
        }

    }
}
