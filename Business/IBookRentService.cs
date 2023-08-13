using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IBookRentService
    {
        public void Add(int customerId, int bookId);
        public void Delete(int Id);
        public List<CustomerAndBook> GetAll();
        public void GetBookBack(int Id);
    }
}
