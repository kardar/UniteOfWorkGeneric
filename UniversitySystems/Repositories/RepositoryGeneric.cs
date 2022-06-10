using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystems.Repositories
{
    internal class RepositoryGeneric<T> : IRepository<T> where T : class
    {
        List<T> list = new();
        public void Add(T entiy)
        {
            if(entiy != null)
            {
            list.Add(entiy);
                 

            }
            else
            {
                Console.WriteLine("Not working");
            }
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetALL()
        {
            return list.ToList();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
