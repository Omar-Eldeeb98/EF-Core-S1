using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_S1.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public string Address { get; set; }

        //[ForeignKey(nameof(Department.Manager))]

        public int MEmpId { get; set; } // this column will be the foriegn key

        public Employee Manager { get; set; }  // navigigtional property (relationship)

        public List<Employee> Employees { get; set; } // navigigtional property (relationship)
    }
}