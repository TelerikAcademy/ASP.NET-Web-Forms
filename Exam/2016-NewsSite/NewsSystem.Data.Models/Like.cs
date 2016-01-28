namespace NewsSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Like
    {
        public int Id { get; set; }

        public bool Value { get; set; }

        public string AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual User Author { get; set; }

        public int ArticleId { get; set; }

        [ForeignKey("ArticleId")]
        public virtual Article Article { get; set; }
    }
}