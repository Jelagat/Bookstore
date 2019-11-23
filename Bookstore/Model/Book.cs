using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Model
{
    public class Book
    {
        [key]
        public int Id { get; set; }
        [Reguired]
        public string Name { get; set; }
        public string Author { get; set }
    }
}
