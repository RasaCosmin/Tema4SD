using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tema4MvcApp.Models
{
    public class LoginUser
    {
        private String _username;
        private String _password;

        [Required(ErrorMessage = "Please type your Username")]
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        [Required(ErrorMessage = "Please type your Password")]
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}