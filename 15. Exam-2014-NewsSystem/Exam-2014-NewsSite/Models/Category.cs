namespace NewsSite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public class Category
    {
        public Category()
        {
            this.Articles = new HashSet<Article>();
        }
        [Key]
        public int ID { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MaxLength(150)]
        public string Name { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}