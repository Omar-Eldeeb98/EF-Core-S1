using EF_Core_S1.Contexts;
using EF_Core_S1.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_S1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //  CRUD Operations :
            //--------------------------

            // prepare database connection for crud operations
            using (CompanyDBContext companyDBContext = new CompanyDBContext())
            {
                #region 1 - create or insert

                //var employee = new Employee()
                //{
                //    Name = "ahmed",
                //    Salary = 5000,
                //    Age = 20,
                //    Address = "gaza"
                //};

                //Console.WriteLine(companyDBContext.Entry(employee).State); //Detached
                //companyDBContext.Employees.Add(employee);
                //Console.WriteLine(companyDBContext.Entry(employee).State); // Added
                //companyDBContext.SaveChanges();
                //Console.WriteLine(companyDBContext.Entry(employee).State); // Unchanged

                #endregion 1 - create or insert

                #region 2 - read or select

                //var result = companyDBContext.Employees.Where(e => e.EmpID == 9).FirstOrDefault();
                //Console.WriteLine(result?.Address); // gaza
                //Console.WriteLine(result?.EmpID); // 9
                //Console.WriteLine("\n");

                //var result2 = companyDBContext.Employees.Select(e => e.Name).ToList();
                //foreach (var item in result2)
                //{
                //    Console.WriteLine(item);
                //}
                //Console.WriteLine("\n");

                #endregion 2 - read or select

                #region 3 - update

                //var res = companyDBContext.Employees.FirstOrDefault(e => e.EmpID == 9);
                //Console.WriteLine(companyDBContext.Entry(res).State); // unchanged

                //res.Name = " Employee9";
                //companyDBContext.Update(res);
                //Console.WriteLine(companyDBContext.Entry(res).State); // Modified

                //companyDBContext.SaveChanges();
                //Console.WriteLine(companyDBContext.Entry(res).State); //unchanged

                #endregion 3 - update

                #region 4 - delete

                //var emp = companyDBContext.Employees.Where(e => e.EmpID == 9).FirstOrDefault();
                //Console.WriteLine(companyDBContext.Entry(emp).State); // Unchanged

                //companyDBContext.Remove(emp);
                //Console.WriteLine(companyDBContext.Entry(emp).State);  // Deleted

                //companyDBContext.SaveChanges();
                //Console.WriteLine(companyDBContext.Entry(emp).State);  // Detached

                #endregion 4 - delete
            }
        }
    }
}