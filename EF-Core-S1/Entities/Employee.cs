using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_S1.Entities
{
    // Ways For Mapping Classes In DataBase :

    #region 1 - by convension ----> this is default behaviour

    //internal class Employee
    //{
    // properties
    //public  int id { get; set; } // public numeric property 'id' || Employeeid
    //public string? name { get; set; }  // nvarchar(max) , allow null
    //public int? age { get; set; } // allow null
    //public  double salary { get; set; } // not allow null , float

    //}

    #endregion 1 - by convension ----> this is default behaviour

    #region 2 - by data annotation (set of attributes used for data validation)

    //[Table("Employee", Schema = "dbo")]
    //internal class Employee
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    //    public int EmpID { get; set; }

    //    [Required]
    //    [Column(TypeName = "varchar(50)")]
    //    [MaxLength(50)]
    //    [StringLength(50, MinimumLength = 10)]
    //    public string? Name { get; set; }

    //    [Column(TypeName = "money")]
    //    public double Salary { get; set; }

    //    [Required]
    //    [Range(20, 60)]
    //    public int? Age { get; set; }

    //    public string Address { get; set; }

    //    [NotMapped]
    //    public double TotalSalary { get; set; }

    //}

    #endregion 2 - by data annotation (set of attributes used for data validation)

    #region 3 - by FluentApi

    // to use this way ----> you should override OnModelCreating()

    //internal class Employee
    //{
    //    public int EmpID { get; set; }
    //    public string? Name { get; set; }

    //    public double Salary { get; set; }

    //    public int? Age { get; set; }

    //    public string Address { get; set; }

    //    public double TotalSalary { get; set; }

    //}

    #endregion 3 - by FluentApi

    #region 4 - By Configuration Class

    internal class Employee
    {
        public int EmpID { get; set; }
        public string? Name { get; set; }

        public double Salary { get; set; }

        public int? Age { get; set; }

        public string Address { get; set; }

        public double TotalSalary { get; set; }

        //[InverseProperty(nameof(Department.Manager))]

        public Department Department { get; set; }  // navigational property

        public int? WorkforId { get; set; } // fk

        public Department? Workfor { get; set; } // navigational property
    }

    #endregion 4 - By Configuration Class
}