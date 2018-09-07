using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EurosSite.Models
{
    public class RegisterFormViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string HomeAddress { get; set; }
        public string Country { get; set; }
        public string Club { get; set; }
        public string PhoneNumber { get; set; }

    }
}