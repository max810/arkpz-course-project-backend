﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARKPZ_CourseWork_Backend.Models
{
    public class Driver
    {
        // TODO Add email, login, etc
        public int Id { get; set; }
        public int TrustLevel { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}