using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppDemo.Models
{
    internal class LoginViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public bool LoginFailureHidden { get; set; } = true;

        public bool ValidateLogin(out string jwtToken)
        {
            if (Username.Equals("Test") && Password.Equals("Test"))
            {
                jwtToken = "123456";
                return true;
            }

            //Not valid
            jwtToken = null;
            LoginFailureHidden = false;
            return false;
        }
    }
}