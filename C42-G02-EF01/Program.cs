using C42_G02_EF01.Contexts;
using C42_G02_EF01.Entities;

namespace C42_G02_EF01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (ITIDBContext iTIDBContext = new ITIDBContext())
            {
                #region Q1: Do CRUD operations on all tables (Use Previous Assignment)

                #region Student Table

                // Create
                //Student student = new Student()
                //{
                //    FName = "omar",
                //    LName = "eldeeb",
                //    Address = "123 cairo",
                //    Age = 30,
                //    Dep_Id = 1
                //};
                //iTIDBContext.Students.Add(student);
                //Console.WriteLine(iTIDBContext.Entry(student).State);
                //iTIDBContext.SaveChanges();

                // Read
                //var res = iTIDBContext.Students.ToList();
                //foreach (var item in res)
                //{
                //    Console.WriteLine(item.FName); // omar
                //}

                // Update
                //var res = iTIDBContext.Students.Where(s => s.Id == 1).FirstOrDefault();
                //res.Address = "Palestine";
                //iTIDBContext.SaveChanges();

                // Delete
                //var res = iTIDBContext.Students.Where(s => s.Id == 2).FirstOrDefault();
                //iTIDBContext.Students.Remove(res);
                //iTIDBContext.SaveChanges();

                #endregion Student Table

                #region Course Table

                // Create
                //Course course = new Course()
                //{
                //    Name = "html",
                //    Description = "any thing ",
                //    Duration = "2 months",
                //    Top_ID = 2,
                //};
                //iTIDBContext.Courses.Add(course);
                //iTIDBContext.SaveChanges();

                // Read
                //var res = iTIDBContext.Courses.Where(c => c.ID == 1 && c.Top_ID == 2);
                //foreach (var item in res)
                //{
                //    Console.WriteLine(item.Description);  // any thing
                //}

                // Update
                //var res = iTIDBContext.Courses.Where(c => c.ID == 1 && c.Top_ID == 2).FirstOrDefault();
                //res.Name = "CSS3";
                //iTIDBContext.SaveChanges();

                // Delete
                //var res = iTIDBContext.Courses.FirstOrDefault(c => c.ID == 1);
                //iTIDBContext.Courses.Remove(res);
                //iTIDBContext.SaveChanges();

                #endregion Course Table

                #region Stud_Course Table

                // Create
                //Stud_Course stud_Course = new Stud_Course()
                //{
                //    stud_ID = 1,
                //    Course_ID = 2,
                //    Grade = 85,
                //};
                //iTIDBContext.Stud_Courses.Add(stud_Course);
                //iTIDBContext.SaveChanges();

                // Read
                //var res = iTIDBContext.Stud_Courses.Where(sc => sc.stud_ID == 1 && sc.Course_ID == 2);
                //foreach (var item in res)
                //{
                //    Console.WriteLine(item.Grade);  // 85.00
                //}

                // Update
                //var res = iTIDBContext.Stud_Courses.Where(sc => sc.stud_ID == 1 && sc.Course_ID == 2).FirstOrDefault();
                //res.Grade = 65;
                //iTIDBContext.SaveChanges();

                // Delete
                //var res = iTIDBContext.Stud_Courses.Where(sc => sc.stud_ID == 1 && sc.Course_ID == 3).FirstOrDefault();
                //iTIDBContext.Stud_Courses.Remove(res);
                //iTIDBContext.SaveChanges();

                #endregion Stud_Course Table

                #region Topic Table

                // Create
                //Topic topic = new Topic()
                //{
                //    Name = "proplem solving"
                //};
                //iTIDBContext.Topics.Add(topic);
                //iTIDBContext.SaveChanges();

                // Read
                //var res = iTIDBContext.Topics.ToList();
                //foreach (var item in res)
                //{
                //    Console.WriteLine(item.Name);

                //}

                // Update
                //var res = iTIDBContext.Topics.Where(t => t.ID == 1).FirstOrDefault();
                //res.Name = "dev oops";
                //iTIDBContext.SaveChanges();

                // Delete
                //var res = iTIDBContext.Topics.Where(t => t.ID == 2).FirstOrDefault();
                //iTIDBContext.Topics.Remove(res);
                //iTIDBContext.SaveChanges();

                #endregion Topic Table

                #region Department Table

                // Create
                //Department department = new Department()
                //{
                //    Name = "Department1",
                //    HiringDate = DateTime.Now,
                //    Ins_ID = 1
                //};
                //iTIDBContext.Departments.Add(department);
                //iTIDBContext.SaveChanges();

                // Red
                //var res = iTIDBContext.Departments.ToList();
                //foreach (var item in res)
                //{
                //    Console.WriteLine(item.Name);
                //}

                // Update
                //var res = iTIDBContext.Departments.Where(d => d.ID == 1).FirstOrDefault();
                //res.Ins_ID = 1;
                //iTIDBContext.SaveChanges();

                // Delete
                //var res = iTIDBContext.Departments.Where(d => d.ID == 2).FirstOrDefault();
                //iTIDBContext.Departments.Remove(res);
                //iTIDBContext.SaveChanges();

                #endregion Department Table

                #region Instructor Table

                // Create
                //Instructor instructor = new Instructor()
                //{
                //    Name = "mark",
                //    Bouns = 570,
                //    Salary = 12000,
                //    HourRate = 7,
                //    Dept_ID = 1,
                //    Adress = "alexandria"
                //};
                //iTIDBContext.Instructors.Add(instructor);
                //iTIDBContext.SaveChanges();

                // Read
                //var res = iTIDBContext.Instructors.ToList();
                //foreach (var item in res)
                //{
                //    Console.WriteLine($"{item.ID} , {item.Name}");
                //}

                // Update
                //var res = iTIDBContext.Instructors.FirstOrDefault(i => i.ID == 1);
                //res.Adress = "usa";
                //iTIDBContext.SaveChanges();

                // Delete
                //var res = iTIDBContext.Instructors.FirstOrDefault(i => i.ID == 5);
                //iTIDBContext.Instructors.Remove(res);
                //iTIDBContext.SaveChanges();

                #endregion Instructor Table

                #region Course_Inst table

                // Create
                //Course_Inst course_Inst = new Course_Inst()
                //{
                //    inst_ID = 1,
                //    Course_ID = 2,
                //    evaluate = "very good"
                //};
                //iTIDBContext.Course_Insts.Add(course_Inst);
                //iTIDBContext.SaveChanges();

                // Read
                //var res = iTIDBContext.Course_Insts.ToList();
                //foreach (var item in res)
                //{
                //    Console.WriteLine(item.evaluate);
                //}

                // Update
                //var res = iTIDBContext.Course_Insts.Where(ci => ci.inst_ID == 1 && ci.Course_ID == 2).FirstOrDefault();
                //res.evaluate = "poor";
                //iTIDBContext.SaveChanges();

                // Delete
                //var res = iTIDBContext.Course_Insts.Where(ci => ci.inst_ID == 1 && ci.Course_ID == 2).FirstOrDefault();
                //iTIDBContext.Course_Insts.Remove(res);
                //iTIDBContext.SaveChanges();

                #endregion Course_Inst table

                #endregion Q1: Do CRUD operations on all tables (Use Previous Assignment)
            }
        }
    }
}