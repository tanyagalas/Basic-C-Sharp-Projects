﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects 
{
    class Employee : Person
    {
        public Employee(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}