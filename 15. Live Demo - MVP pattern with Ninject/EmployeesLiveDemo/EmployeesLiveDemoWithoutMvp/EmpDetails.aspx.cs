using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeesLiveDemoWithoutMvp
{
    public partial class EmpDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NorthwindEntities entities = new EmployeesLiveDemoWithoutMvp.NorthwindEntities();

            int id = int.Parse(this.Request.QueryString["id"]);
            this.DetailsView.DataSource = entities.Employees.Where(em => em.EmployeeID == id).ToList();
            this.DetailsView.DataBind();
        }
    }
}