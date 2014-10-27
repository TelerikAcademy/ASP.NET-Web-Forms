using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LikeUserControl.Models
{
    public class Post
    {
        public Post()
        {
            this.Likes = new HashSet<Like>();
        }

        public int ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; }

        public string AuthorID { get; set; }

        public virtual AppUser Author { get; set; }

        public virtual ICollection<Like> Likes { get; set; }
    }
}