using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class CRUD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = GetPersons();
            GridView1.DataBind();
        }

        public List<Person> GetPersons()
        {
            List<Person> persons=new List<Person>()
            {
                new Person(){Name = "Rasif",SSN = "11"},
                new Person(){Name = "Asif",SSN = "21"},
                new Person(){Name = "Josinta",SSN = "31"},
                new Person(){Name = "Zamal",SSN = "41"},
                new Person(){Name = "Aziz",SSN = "51"},
            };
            return persons;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string SSN { get; set; }
    }
}