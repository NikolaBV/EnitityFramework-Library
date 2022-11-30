using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Data.Models
{
    public class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
