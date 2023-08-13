using Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EfCustomerDal : ICustomerDal
    {
       
        public void Add(Customer customer)
        {
            using (LibraryAutomation libraryAutomation = new LibraryAutomation())
            {
                
                libraryAutomation.Add(customer);
                
                libraryAutomation.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (LibraryAutomation libraryAutomation = new LibraryAutomation())
            {
                var productToUpdate = (libraryAutomation.Customers.SingleOrDefault(p => p.CustomerId == Id));
                productToUpdate.ActiveOrPassive = false; // müşterilerin aktiflik durumu = false, silme işlemi müşterileri sql tablosundan silmez aktiflik durumunu değiştirir, (ilişkili veri tabanı)
                libraryAutomation.SaveChanges();
            }
        }

        public List<Customer> GetAll()
        {
            using(LibraryAutomation libraryAutomation = new LibraryAutomation())
            {

                


                 var Customers1 = libraryAutomation.Customers
                    
                 .Where(b => b.ActiveOrPassive == true) // sadece aktif üyeleri listeler
             
                

                 .ToList();
                 return Customers1;





               
            }
        }

        
    }
}
