using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EfBookDal : IBookDal
    {
        public void Add(Book book) // kitap eklemek
        {
            using (LibraryAutomation libraryAutomation = new LibraryAutomation())
            {
                libraryAutomation.Add(book);
                libraryAutomation.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (LibraryAutomation libraryAutomation = new LibraryAutomation())
            {
                var bookToUpdate = (libraryAutomation.Books.SingleOrDefault(p => p.BookId == Id));
                bookToUpdate.IsActive = false;
                libraryAutomation.SaveChanges(); //kitap aktiflik durumu = false, silme işlemi kitabı silmez aktiflik durumunu değiştirir
            }
        }

        public List<Book> GetAll()
        {
            using (LibraryAutomation libraryAutomation = new LibraryAutomation())
            {

                var Books = libraryAutomation.Books

                .Where(b => b.IsActive == true) // sadece aktif kitaplar listelenir


                .ToList();
                return Books;
            }
        }

       

        
    }
}
