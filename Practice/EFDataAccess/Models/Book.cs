using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccess.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }

        public DateTime DateTime { get; set; }
    }
}
