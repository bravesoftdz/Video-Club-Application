﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Club_Application
{
    class Category
    {
        public string id { get; set; }
        public string name { get; set; }

        public Category(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
