using DbFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace DbFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ItiContext db = new ItiContext();

            //var depts = db.Departments.ToList();
            //Console.WriteLine(depts.Count);
            //foreach (var dept in depts)
            //{
            //    Console.WriteLine(dept);
            //}

            //Console.WriteLine("-----------------------------");
            //var students = db.Students.ToList();
            //Console.WriteLine(students.Count);
            //foreach(var std in students)
            //{
            //    Console.WriteLine(std);
            //}


            // Eager Loading
            //var student = db.Students.Include(s=>s.Dept).FirstOrDefault(s => s.StId == 5);
            //if (student is null)
            //{
            //    Console.WriteLine("not found");
            //}
            //else
            //{
            //    Console.WriteLine(student.StFname);
            //    Console.WriteLine(student.StLname);
            //    Console.WriteLine(student.Dept?.DeptName);
            //}

            // Explicit Loading
            //var student = db.Students.FirstOrDefault(s => s.StId == 9);
            //if (student is null)
            //{
            //    Console.WriteLine("not found");
            //}
            //else
            //{
            //    Console.WriteLine(student.StFname);
            //    Console.WriteLine(student.StLname);

            //    db.Entry(student).Reference(s => s.Dept).Load();
            //    Console.WriteLine(student.Dept?.DeptName);
            //}

            // Lazy Loading
            //var student = db.Students.FirstOrDefault(s => s.StId == 9);
            //if (student is null)
            //{
            //    Console.WriteLine("not found");
            //}
            //else
            //{
            //    Console.WriteLine(student.StFname);
            //    Console.WriteLine(student.StLname);
            //    Console.WriteLine(student.Dept.DeptName);
            //}


            //// N+1 query 
            //var students = db.Students.ToList();  // one query
            //if (students is null)
            //{
            //    Console.WriteLine("not found");
            //}
            //else
            //{
            //    // loop 1:100
            //    foreach (var student in students)
            //    {
            //        Console.WriteLine(student.StFname);
            //        Console.WriteLine(student.StLname);
            //        Console.WriteLine(student.Dept?.DeptName); // new query 
            //    }
            //}

            // How to solve N+1 Query
            //var students = db.Students.Include(s=>s.Dept).ToList();  // one query
            //if (students is null)
            //{
            //    Console.WriteLine("not found");
            //}
            //else
            //{
            //    // loop 1:100
            //    foreach (var student in students)
            //    {
            //        Console.Write(student.StFname);
            //        Console.Write(student.StLname);
            //        Console.WriteLine(student.Dept?.DeptName);
            //    }
            //}

            //// Tracking
            //var student = db.Students.Include(s => s.Dept).FirstOrDefault(s => s.StId == 5);
            //if (student is null)
            //{
            //    Console.WriteLine("not found");
            //}
            //else
            //{
            //    Console.WriteLine(student.StFname);
            //    // update
            //    student.StFname = "Shahd";
            //    db.SaveChanges();
            //}

            var students = db.Students.AsNoTracking().Include(s => s.Dept).ToList();  // one query
            if (students is null)
            {
                Console.WriteLine("not found");
            }
            else
            {
                // loop 1:100
                foreach (var student in students)
                {
                    Console.Write(student.StFname);
                    Console.Write(student.StLname);
                    Console.WriteLine(student.Dept?.DeptName);
                    if(student.StId == 5)
                    {
                        student.StLname = "Mohmed";
                        db.Entry(student).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
