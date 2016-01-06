namespace NewsSite.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Like
    {
        [Key, Column(Order = 0)]
        public string UserID { get; set; }
        [Key, Column(Order = 1)]
        public int ArticleID { get; set; }

        public virtual Article Article { get; set; }

        public virtual AppUser User { get; set; }

        [Required]
        public int Value { get; set; }
    }
}
