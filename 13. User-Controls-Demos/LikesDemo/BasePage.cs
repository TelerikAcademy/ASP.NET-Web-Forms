using LikesDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace LikesDemo
{
    public class BasePage : Page
    {
        public AppDbContext dbContext { get; set; }

        public BasePage()
        {
            this.dbContext = new AppDbContext(); 
        }
    }
}
