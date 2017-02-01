using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeesLiveDemoWithoutMvp
{
    public partial class Employee : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NorthwindEntities entities = new NorthwindEntities();

            this.GridView1.DataSource = entities.Employees.ToList();
            this.GridView1.DataBind();
        }
    }
}