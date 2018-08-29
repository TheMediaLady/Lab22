using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab21.Models
{
    public class NewUserModel
    {
        public string LastName { get; set;}
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public NewUserModel(string firstName)
        {
            FirstName = firstName;
        }
        public string NewUserThanks()
        {
            return ($"Thank you {FirstName} for registering");
        }
    }

    
}