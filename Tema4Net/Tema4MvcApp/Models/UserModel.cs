using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tema4MvcApp.Models
{
    public class UserModel
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Please type your Username")]
        public String username { get; set; }
        [Required(ErrorMessage = "Please type your Username")]
        public String password { get; set; }
        public String role { get; set; }
    }
}