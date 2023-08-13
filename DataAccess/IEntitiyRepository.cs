using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IEntitiyRepository<T>where T : class, IEntitiy, new()
    {
        List<T> GetAll();

        void Add(T entity);

        

        void Delete(int Id);

        


    }
}
