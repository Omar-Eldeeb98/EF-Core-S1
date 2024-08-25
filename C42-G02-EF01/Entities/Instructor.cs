using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_EF01.Entities
{
    internal class Instructor
    {
        // properties
        public int ID { get; set; }

        public string Name { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Adress { get; set; }
        public decimal HourRate { get; set; }
        public int Dept_ID { get; set; }
    }
}