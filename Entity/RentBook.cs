using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BookRent
    {
        
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int BookId { get; set; }
        
        public virtual Book Book { get; set; }
        public virtual Customer Customer { get; set; }



    }
}
