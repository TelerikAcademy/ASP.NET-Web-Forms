using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LikesDemo.Models
{
    public class Like
    {
        public int ID { get; set; }

        public bool? Value { get; set; }

        public int PostID { get; set; }

        public virtual Post Post { get; set; }

        public string UserID { get; set; }

        public virtual AppUser User { get; set; }
    }
}