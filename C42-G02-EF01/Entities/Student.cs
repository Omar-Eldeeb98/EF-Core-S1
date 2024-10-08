﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF01.Entities
{
    internal class Student
    {
        // properties
        public int Id { get; set; }

        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int? Dep_Id { get; set; }

        public Department? Department { get; set; }  // navigational property

        public ICollection<Stud_Course> StudentsCourse { get; set; } // navigational property
    }
}