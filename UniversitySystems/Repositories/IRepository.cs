using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystems.Repositories
{
    internal interface IRepository<T> where T : class
    {
        void Add(T entiy);

        void Delete(T entity);

        public List<T> GetALL();

        public T GetById(int id);
    }
}
