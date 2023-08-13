using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public class BookRentManager : IBookRentService
    {
        IBookRentDal _rentbook;

        public BookRentManager(IBookRentDal bookRentDal)
        {
            _rentbook = bookRentDal;
        }

        public void Add(int customerId, int bookId)
        {
            _rentbook.Add(customerId,bookId);
        }

        public void Delete(int Id)
        {
            _rentbook.Delete(Id);
        }

         public List<CustomerAndBook> GetAll()
         {
            return _rentbook.GetAll();
         }

        public void GetBookBack(int Id)
        {
            _rentbook.GetBookBack(Id);
        }
    }
}
