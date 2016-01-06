using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Strongly_Typed_Session_Wrapper
{
    public class PersonSession
    {
        // This key is used to identify object from session
        const string KEY = "personDetails";

        public PersonSession(int id, string name, int age, bool emailValidated)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.HasEmailValidated = emailValidated;
        }

        public static PersonSession GetPersonSession()
        {
            return HttpContext.Current.Session[KEY] as PersonSession;
        }

        public static void CreatePersonSession(PersonSession person)
        {
            HttpContext.Current.Session[KEY] = person;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public bool HasEmailValidated { get; private set; }
    }
}