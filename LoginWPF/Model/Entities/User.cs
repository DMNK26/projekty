﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWPF.Model.Entities
{
    public class User
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }
}
