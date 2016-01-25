namespace LikesDemo.Models
{
    using System.Collections.Generic;

    public class Post
    {
        public Post()
        {
            this.Likes = new HashSet<Like>();
        }
        public int ID { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public virtual ICollection<Like> Likes { get; set; }
    }
}