﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JBCSite.Web.ViewModels
{
    public class CreateUserViewModel
    {
        public string UserName { get; set; }
        
        public string Email { get; set; }

        public string Password { get; set; }
    }
}