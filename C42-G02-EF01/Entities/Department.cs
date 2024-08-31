using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF01.Entities
{
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [ForeignKey(nameof(Instructor))]
        public int? Ins_ID { get; set; }

        public DateTime HiringDate { get; set; }

        public ICollection<Student> Students { get; set; }  // navigational property

        public ICollection<Instructor> Instructors { get; set; } // navigational property
        public Instructor Instructor { get; set; }
    }
}