using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF01.Entities
{
    internal class Course
    {
        // properties
        public int ID { get; set; }

        public string Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Top_ID { get; set; }

        public ICollection<Stud_Course> CoursesStudent { get; set; }  // navigational property

        public Topic Topic { get; set; } // navigational property

        public ICollection<Course_Inst> Course_Insts { get; set; } // navigational property
    }
}