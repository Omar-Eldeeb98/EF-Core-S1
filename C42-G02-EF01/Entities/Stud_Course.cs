using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF01.Entities
{
    internal class Stud_Course
    {
        public int stud_ID { get; set; }
        public int Course_ID { get; set; }

        public decimal? Grade { get; set; }

        public Student Student { get; set; } // navigational property

        public Course Course { get; set; } // navigational property
    }
}