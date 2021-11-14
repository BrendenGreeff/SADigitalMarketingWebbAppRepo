using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SADigitalMarketingWebbApp.Models
{
    public class UsersModel
    {
        public int Users_ID { get; set; }
        public string Users_Fname { get; set; }
        public string Users_Lname { get; set; }
        public string Users_Username { get; set; }
        public string Users_Email{ get; set; }
        public string Users_PhoneNumber { get; set; }
        public DateTime Users_DOB { get; set; }
        public string Users_Password { get; set; }
        
    }
}
