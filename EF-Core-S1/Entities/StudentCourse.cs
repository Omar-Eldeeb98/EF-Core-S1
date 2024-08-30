using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_S1.Entities
{
    internal class StudentCourse
    {
        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }

        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }

        public int Grade { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}