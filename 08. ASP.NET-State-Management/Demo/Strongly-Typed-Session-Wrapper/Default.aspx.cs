using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Strongly_Typed_Session_Wrapper
{
    public partial class Default : System.Web.UI.Page
    {
        protected PersonSession Person;

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            // check the person details existance here
            PersonSession person = PersonSession.GetPersonSession();
            if (person == null)
            {
                this.lblIsLogged.Text = "Not logged!";
            }
            else
                this.Person = person;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSavePersonDetails_Click(object sender, EventArgs e)
        {
            PersonSession person = new PersonSession(int.Parse(tbPersonId.Text),
            tbName.Text, int.Parse(tbAge.Text), chkEmailValidated.Checked);
            PersonSession.CreatePersonSession(person);
        }

        protected void btnGetPersonDetails_Click(object sender, EventArgs e)
        {

        }
    }
}