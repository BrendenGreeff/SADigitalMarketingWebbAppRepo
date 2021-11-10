using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SADigitalMarketingWebbApp.Models
{
    public class UsersModel
    {
        public int User_ID { get; set; }
        public string User_Fname { get; set; }
        public string User_Lname { get; set; }
        public string User_Username { get; set; }
        public string User_Email{ get; set; }
        public int User_PhoneNumber { get; set; }
        public DateTime User_DOB { get; set; }
        public int User_Password { get; set; }
        public int User_AccessLevel { get; set; }
    }
}
