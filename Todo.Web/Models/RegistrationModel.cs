using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Todo.Web.Models
{
    public class RegistrationModel : LoginModel
    {
        public string ConfirmPassword { get; set; }
    }
}