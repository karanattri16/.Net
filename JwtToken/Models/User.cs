﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JwtToken.Models
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
    }
    public enum UserRole
    {
        Normal,
        Admin
    }
}