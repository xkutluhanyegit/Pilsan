using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class SignUpVM
    {
        public SignUpVM()
        {
            
        }
        public SignUpVM(string _email,string _username, string _password)
        {
            email = _email;
            username = _username;
            password = _password;
        }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}