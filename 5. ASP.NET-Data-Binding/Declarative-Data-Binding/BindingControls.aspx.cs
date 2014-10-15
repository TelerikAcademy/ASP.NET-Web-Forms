using System;
using System.Collections.Generic;

public partial class BindingControls : System.Web.UI.Page 
{
    private Random rnd = new Random();

    public int GetRandomNumber()
    {
        return rnd.Next(100);
    }

    public string[] Towns
    {
        get
        {
            return new string[] { "Sofia", "Plovdiv", "Varna" };
        }
    }

    public Person Manager
    {
        get
        {
            return new Person { FirstName = "<b>Peter</b>", LastName = "Ivanov" };
        }
    }

    public IEnumerable<Person> GetPeople()
    {
        return new List<Person>
        {
            new Person { FirstName = "Doncho", LastName = "Minkov" },
            new Person { FirstName = "Nikolay", LastName = "Kostov" },
            new Person { FirstName = "Ivaylo", LastName = "Kenov" },
        };
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Page.DataBind();
    }
}
