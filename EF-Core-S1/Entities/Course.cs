using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_S1.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<StudentCourse> CourseStudents { get; set; } = new HashSet<StudentCourse>();

        //public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        // navigational property (many)
    }
}