﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Model
{
    public class User
    {
        public int userId { get; set; }


        public string login { get; set; }
        public string password { get; set; }
        public string mail { get; set; }
        public DateTime registrationDate { get; set; }



    }
}
