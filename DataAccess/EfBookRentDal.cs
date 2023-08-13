using Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Tls.Crypto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EfBookRentDal : IBookRentDal
    {
        public void Add(int customerId, int bookId) //datagrid kısmından gelen Id bilgileri
        {
            using (LibraryAutomation libraryAutomation = new LibraryAutomation())
            {

                var customer = libraryAutomation.Customers.FirstOrDefault(c => c.CustomerId == customerId);
                var book = libraryAutomation.Books.FirstOrDefault(b => b.BookId == bookId);

                var rentedBook = new BookRent
                {
                    CustomerId = customerId,
                    BookId = bookId,
                    
                    
                };

                libraryAutomation.BookRents.Add(rentedBook);
                libraryAutomation.SaveChanges();
            }





          
           
            
        }

        public void Delete(int ıd)//datagrid kısmından gelen Id bilgileri
        {
            using (LibraryAutomation libraryAutomation = new LibraryAutomation())
            {
                libraryAutomation.BookRents.Remove(libraryAutomation.BookRents.SingleOrDefault(p => p.Id == ıd));
                libraryAutomation.SaveChanges();
            }
        }

         public List<CustomerAndBook> GetAll()
         {
            using (LibraryAutomation libraryAutomation = new LibraryAutomation())
            {
                var query = from item in libraryAutomation.BookRents
                            select new CustomerAndBook
                            {
                                CustomerName = item.Customer.CustomerName,
                                CustomerLastName = item.Customer.CustomerLastName,
                                BookName = item.Book.BookName,
                                Id = item.Id,
                                BookId = item.BookId
                            }; //ilişkili sql tablosu kullanılır 

                return query.ToList();


            }
            }

        public void GetBookBack(int Id) // kiralanan kitabın geri verilmesi durumu 
        {
            using (LibraryAutomation libraryAutomation = new LibraryAutomation())
            {
                var bookToUpdate = (libraryAutomation.BookRents.SingleOrDefault(p => p.BookId == Id));

                int bookId = bookToUpdate.BookId;
                var productToUpdate = (libraryAutomation.Books.SingleOrDefault(p => p.BookId == bookId));
                productToUpdate.IsActive = true;
               
                libraryAutomation.SaveChanges(); //kitap aktiflik durumu = true 
            }
        }   
    }
}
