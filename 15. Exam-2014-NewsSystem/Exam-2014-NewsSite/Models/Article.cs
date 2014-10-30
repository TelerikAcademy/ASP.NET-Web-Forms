namespace NewsSite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class Article
    {
        public Article()
        {
            this.Likes = new HashSet<Like>();
        }

        [Key]
        public int ID { get; set; }
        
        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public string AuthorID { get; set; }

        public virtual AppUser Author { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Like> Likes { get; set; }
    }
}