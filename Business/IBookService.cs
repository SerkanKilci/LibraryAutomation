using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IBookService
    {
        List<Book> GetAll();

        void Add(Book book);

        void Delete(int Id);
    }
}
