using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Library> Libraries { get; set; }
    }
}
