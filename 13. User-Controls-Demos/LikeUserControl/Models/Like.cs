using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LikeUserControl.Models
{
    public class Like
    {
        public int ID { get; set; }

        public int Value { get; set; }

        public DateTime DateCreated { get; set; }

        public string AuthorID { get; set; }

        public virtual AppUser Author { get; set; }

        public int PostID { get; set; }

        public virtual Post Post { get; set; }
    }
}
