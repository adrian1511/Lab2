using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class LoginRegisterModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        [DisplayName("Запомнить меня")]
        public bool RememberMe { get; set; }
    }
}