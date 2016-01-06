using NewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace NewsSite
{
    public class BasePage : Page
    {
        public NewsDbContext dbContext;

        public BasePage()
        {
            this.dbContext = new NewsDbContext();
        }
    }
}
