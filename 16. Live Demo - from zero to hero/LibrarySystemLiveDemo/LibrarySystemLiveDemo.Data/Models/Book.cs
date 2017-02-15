using System;
using System.ComponentModel.DataAnnotations;

namespace LibrarySystemLiveDemo.Data.Models
{
    public class Book
    {
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        public string ISBN { get; set; }

        public string WebSite { get; set; }

        public string Description { get; set; }

        public Guid CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}