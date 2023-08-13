using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CustomerAndBook
    {

        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public string BookName { get; set; }

        public int Id { get; set; }
        public int BookId { get; set; }
    }
}
