﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF01.Entities
{
    internal class Course_Inst
    {
        public int inst_ID { get; set; }
        public int Course_ID { get; set; }
        public string evaluate { get; set; }

        public Course Course { get; set; }  // navigational property
        public Instructor Instructor { get; set; }  // navigational property
    }
}