using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void Add(Book kitap)
        {
            _bookDal.Add(kitap);
        }

        public void Delete(int id)
        {
            _bookDal.Delete(id);
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }
    }
}
