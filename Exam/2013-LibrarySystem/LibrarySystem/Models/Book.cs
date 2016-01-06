using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibrarySystem.Models
{
    public class Book
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ISBN { get; set; }

        public string WebSite { get; set; }

        public string Author { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}
