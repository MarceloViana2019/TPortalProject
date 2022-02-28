using System;
using System.Collections.Generic;
using System.Text;

namespace TPortalProject.Application.ViewModels
{
    public class UserAuthResponseViewModel
    {
        public UserAuthResponseViewModel(UserViewModel user, string token)
        {
            User = user;
            Token = token;
        }

        public UserViewModel User { get; set; }
        public string Token { get; set; }
    }
}
