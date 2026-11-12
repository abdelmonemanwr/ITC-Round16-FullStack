using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var depts = new List<Department>()
            {
                new Department()
                {
                    Id = 2,
                    Name = ".NET",
                    Location = "Benha"
                },
                new Department()
                {
                    Id = 3,
                    Name = "Java",
                    Location = "Tanta"
                },
                new Department()
                {
                    Id = 1,
                    Name = "PHP",
                    Location = "Sohag"
                },
            };

            var sts = new List<Student>()
            {
                new Student()
                {
                    Id = 2,
                    Age = 21,
                    Fname = "Ahmed",
                    Lname = "Mohamed",
                    DeptId = 1,
                    Courses = new List<Course>()
                    {
                        new Course() { Id = 1, Code = "CS101", Name = "C# Fundamentals", Hours = 15 },
                        new Course() { Id = 3, Code = "DB301", Name = "SQL Server", Hours = 12 },
                        new Course() { Id = 2, Code = "MVC201", Name = "MVC Fundamentals", Hours = 30 },
                    }
                },
                new Student()
                {
                    Id = 3,
                    Age = 19,
                    Fname = "Malak",
                    Lname = "Tamer",
                    DeptId = 2,
                    Courses = new List<Course>()
                    {
                        new Course() { Id = 3, Code = "WEB101", Name = "HTML & CSS", Hours = 10 },
                        new Course() { Id = 4, Code = "JS202", Name = "JavaScript", Hours = 18 }
                    }
                },
                new Student()
                {
                    Id = 1,
                    Age = 20,
                    Fname = "Shahd",
                    Lname = "Ahmed",
                    DeptId = 3,
                    Courses = new List<Course>()
                    {
                        new Course() { Id = 5, Code = "NET301", Name = "ASP.NET Core", Hours = 24 },
                        new Course() { Id = 2, Code = "DB201", Name = "SQL Server", Hours = 12 }
                    }
                },
                new Student()
                {
                    Id = 6,
                    Age = 22,
                    Fname = "Saleh",
                    Lname = "Selim",
                    DeptId = 2,
                    Courses = new List<Course>()
                    {
                        new Course() { Id = 6, Code = "PY101", Name = "Python Basics", Hours = 14 },
                        new Course() { Id = 7, Code = "DS305", Name = "Data Structures", Hours = 20 }
                    }
                },
                new Student()
                {
                    Id = 7,
                    Age = 19,
                    Fname = "Saleh",
                    Lname = "Omar",
                    DeptId = 3,
                    Courses = new List<Course>()
                    {
                        new Course() { Id = 1, Code = "CS101", Name = "C# Fundamentals", Hours = 15 },
                        new Course() { Id = 8, Code = "OOP205", Name = "Object-Oriented Programming", Hours = 16 }
                    }
                },
                new Student()
                {
                    Id = 4,
                    Age = 22,
                    Fname = "Toka",
                    Lname = "Ali",
                    DeptId = 1,
                    Courses = new List<Course>()
                    {
                        new Course() { Id = 9, Code = "UI102", Name = "UI/UX Design", Hours = 12 },
                        new Course() { Id = 10, Code = "RCT301", Name = "React", Hours = 22 }
                    }
                },
                new Student()
                {
                    Id = 5,
                    Age = 20,
                    Fname = "Sagda",
                    Lname = "Mahmoud",
                    DeptId = 1,
                    Courses = new List<Course>()
                    {
                        new Course() { Id = 11, Code = "ALG201", Name = "Algorithms", Hours = 18 },
                        new Course() { Id = 12, Code = "GIT101", Name = "Git & Version Control", Hours = 6 }
                    }
                }
            };

            #region Tradititonal way
            //var result = new List<Student>();
            //foreach (var student in sts)
            //{
            //    if(student.Age >= 20)
            //    {
            //        result.Add(student);
            //    }
            //}

            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region must know before linq

            //var x = query (int, list<int>, list<student> student, ...)

            // Object Initializer
            //Student s = new() { Id = 4};
            ////s.Id = 4;
            //s.Fname = "Men3m";
            //s.Lname = "sdkss";
            //s.Age = 24;

            //Student s2 = new()
            //{
            //    Id = 5,
            //    Age = 21,
            //    Fname = "marwa",
            //    Lname = "magdy"
            //};

            //Anonymous Object: object has no structure, used for projection (Mutable)
            // var objName = new {prop1, prop2};

            // Anonymous Method
            // keyword delegate
            //Func<int, int, int> myDel1 = delegate (int x, int y)
            //{
            //    return x + y;
            //};

            // Lambda Expression
            //Func<int, int, int> myDel2 = (x, y) => x + y;


            // Extension Method
            // static class, static method, this, 1st param
            #endregion

            #region LINQ
            //var q1 = Enumerable.Where(sts, delegate (Student s)
            //{
            //    return s.Id == 1;
            //});
            //Console.WriteLine(q1);

            //var q2 = Enumerable.Where(sts, s => s.Id == 1);
            //var q3 = sts.Where(s => s.Id == 1);
            //var q4 = sts.Where(delegate (Student s) { return s.Id == 1; });

            //var q5 = sts.Select(s=>new
            //{
            //    Fullname = $"{s.Fname} {s.Lname}",
            //    Id = s.Id,
            //    //s.Id.ToString(),
            //});

            //var q55 = Enumerable.Select(sts, s => new
            //{
            //    Fullname = $"{s.Fname} {s.Lname}",
            //    Id = s.Id,
            //    //s.Id.ToString(),
            //});

            //var q6 = Enumerable.Where(sts, s => s.Age >= 21).Select(s => new
            //{
            //    Fullname = $"{s.Fname} {s.Lname}",
            //    Id = s.Id
            //});

            // Method Chaining
            //var q7 = sts.Where(s => s.Age >= 21).Select(s => new {
            //    Id = s.Id,
            //    Fullname = $"{s.Fname} {s.Lname}",
            //});

            //var q8 = Enumerable.Where(sts, delegate (Student s)
            //{
            //    return s.Age >= 21;
            //});

            //var q9 = Enumerable.Select(q8, delegate (Student s)
            //{
            //    return new
            //    {
            //        Fullname = $"{s.Fname} {s.Lname}",
            //        Id = s.Id,
            //    };
            //});

            //var q10 = Enumerable.Select(
            //    Enumerable.Where(sts, delegate (Student s)
            //    {
            //        return s.Age >= 21;
            //    }), 
            //    delegate (Student s)
            //    {
            //        return new
            //        {
            //            Fullname = $"{s.Fname} {s.Lname}",
            //            Id = s.Id,
            //        };
            //    }
            //);

            // Method Expression
            // Query Expression
            //var q11 = from std in sts
            //          where std.Age >= 21
            //          select new
            //          {
            //              Fullname = $"{std.Fname} {std.Lname}",
            //              Id = std.Id
            //          };


            //var q12 = sts.Where(s => s.Age >= 21); // deffered execution
            //var q13 = sts.Where(s => s.Age >= 21).ToList(); // immedite execution
            //Console.WriteLine(q12);
            //sts.Add(new Student() { Id = 7, Age = 23, Fname = "Men3m", Lname = "Anwar" });
            //Console.WriteLine(q12);
            //foreach (var item in q13)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region First, Single, Last, FirstOrDefault, LastOrDefault, SingleOrDefault

            //var q14 = sts.Where(s => s.Id == 3).First();
            //var q15 = sts.Where(s => s.Age >= 21).First();
            //var q16 = sts.Where(s => s.Age >= 31).First();
            //var q17 = sts.Where(s => s.Age >= 31).FirstOrDefault();

            //var q18 = sts.Where(s => s.Id == 3).Last();
            //var q19 = sts.Where(s => s.Age >= 21).Last();
            //var q20 = sts.Where(s => s.Age >= 31).Last();
            //var q21 = sts.Where(s => s.Age >= 31).LastOrDefault();

            //var q22 = sts.Where(s => s.Id == 3).Single();
            //var q23 = sts.Where(s => s.Age >= 21).Single();
            //var q24 = sts.Where(s => s.Age >= 31).Single();
            //var q25 = sts.Where(s => s.Age >= 31).SingleOrDefault();
            //var q26 = sts.Where(s => s.Age >= 21).SingleOrDefault();
            //Console.WriteLine(q26);

            //var q27 = sts.Where(s => s.Age >= 21).Select(s => new { s.Id });
            //var q28 = sts.Select(s => new { myId = s.Id }).Where(s => s.myId >= 21);
            //var q29 = sts.Select(s => new { s.Id, s.Age }).Where(s => s.Age >= 21);
            #endregion

            #region Count, Sum, Min, Max, avg
            //var q30 = sts.Count();
            //var q31 = sts.Sum(s=>s.Age);
            //var q32 = sts.Min(s=>s.Age);
            //var q33 = sts.Max(s=>s.Age);
            //var q34 = sts.Average(s=>s.Age);
            //Console.WriteLine(q34);
            //var q35 = sts.DefaultIfEmpty(new Student() { Id = 55 });

            //var q36 = sts.Where(s => s.Age >= 31)
            //               .DefaultIfEmpty(new Student() { Id = 55, Fname = "test" })
            //               .First();
            //Console.WriteLine(q36);
            #endregion

            #region Take, Skip, TakeWhile, SkipWhile
            //var q37 = sts.Take(2);
            ////Console.WriteLine(q37);
            //foreach(var std in q37)
            //{
            //    Console.WriteLine(std);
            //}
            //var q38 = sts.Skip(2);
            //foreach(var std in q38)
            //{
            //    Console.WriteLine(std);
            //}
            //var q39 = sts.Skip(2).Take(1);
            //foreach(var std in q39)
            //{
            //    Console.WriteLine(std);
            //}
            //var q40 = sts.Take(2).Skip(1);
            //foreach (var std in q40)
            //{
            //    Console.WriteLine(std);
            //}
            //var q41 = sts.TakeWhile(s => s.Age > 20);
            //foreach (var std in q41)
            //{
            //    Console.WriteLine(std);
            //}
            //var q42 = sts.SkipWhile(s => s.Age > 20);
            //foreach (var std in q42)
            //{
            //    Console.WriteLine(std);
            //}
            //var q43 = sts.TakeLast(3);
            //foreach (var std in q43)
            //{
            //    Console.WriteLine(std);
            //}
            //var q44 = sts.SkipLast(3);
            //foreach (var std in q44)
            //{
            //    Console.WriteLine(std);
            //}
            #endregion

            #region OrderBy

            // order by fname
            //var q45 = sts.OrderBy(std => std.Fname);

            // order by fname, age
            //var q46 = sts.OrderBy(std => std.Fname).ThenBy(std => std.Age);

            // order by fname, age desc
            //var q47 = sts.OrderBy(std => std.Fname).ThenByDescending(std => std.Age);

            // order by fname, age desc
            //var q48 = sts.OrderByDescending(std => std.Fname).ThenByDescending(std => std.Age);

            //foreach (var std in q48)
            //{
            //    Console.WriteLine(std);
            //}
            #endregion

            #region Group By
            //var q49 = sts.GroupBy(st => st.Age);

            //foreach (var group in q49)
            //{
            //    Console.WriteLine($"students which are grouped by age = {group.Key} are:");
            //    foreach(var std in group)
            //    {
            //        Console.WriteLine(std);
            //    }
            //    Console.WriteLine("\n----------------\n");
            //}
            #endregion

            #region Select Many
            //List<string> names = [ "ali", "men3m", "saleh", "ahmed" ];
            //List<int> numbers = [ 1, 3, 2 ];

            //var q50 = names.SelectMany(n => numbers, (name, number) => $"{name} - {number}");
            //foreach(var combination in q50)
            //{
            //    Console.WriteLine(combination);
            //}


            //var q51 = sts.SelectMany(s => s.Courses, (std, crs) => $"Id = {std.Id}, FullName = {std.Fname} {std.Lname}, Age = {std.Age}, Course = {crs}");
            //var q51 = sts.SelectMany(s => s.Courses, (std, crs) => $"Student = {std}, Course = {crs}");
            //foreach(var comb in q51)
            //{
            //    Console.WriteLine(comb);
            //}
            #endregion

            #region Distinct

            ////List<string> names = ["ali", new string("men3m"), "saleh", "ahmed", new string("men3m")];
            //List<string> names = ["ali", new string("men3m"), "saleh", "ahmed", new string("men3m")];
            //var q52 = names.Distinct();
            //foreach (var name in q52)
            //{
            //    Console.WriteLine(name);
            //}

            //List<Student> students = new List<Student>
            //{
            //    new Student()
            //    {
            //        Id = 2,
            //        Age = 25,
            //        Courses = new List<Course>()
            //        {
            //            new Course() { Id = 1, Code = "CS101", Name = "C# Fundamentals", Hours = 15 },
            //        },
            //        Fname = "Men3m",
            //        Lname = "Anwar"
            //    },
            //    new Student()
            //    {
            //        Id = 2,
            //        Age = 25,
            //        Courses = new List<Course>()
            //        {
            //            new Course() { Id = 1, Code = "CS101", Name = "C# Fundamentals", Hours = 15 },
            //        },
            //        Fname = "Men3m",
            //        Lname = "Anwar"
            //    },
            //    new Student()
            //    {
            //        Id = 3,
            //        Age = 25,
            //        Courses = new List<Course>()
            //        {
            //            new Course() { Id = 1, Code = "CS101", Name = "C# Fundamentals", Hours = 15 },
            //        },
            //        Fname = "Mo",
            //        Lname = "Anwar"
            //    },
            //    new Student()
            //    {
            //        Id = 1,
            //        Age = 22,
            //        Courses = new List<Course>()
            //        {
            //            new Course() { Id = 12, Code = "CS202", Name = "C++", Hours = 25 },
            //        },
            //        Fname = "Ahmed",
            //        Lname = "Selim"
            //    },
            //};

            //var q53 = students.Distinct(new StudentComparer());
            //foreach (var std in q53)
            //{
            //    Console.WriteLine(std);
            //}
            #endregion

            #region Union, ...
            //List<int> numbers2 = [ 3, 2, 5 ];
            //List<int> numbers3 = [1, 5, 6];
            ////var newList = numbers2.Union(numbers3);
            ////var newList = numbers2.Concat(numbers3);
            ////var newList = numbers2.Intersect(numbers3);
            ////var newList = numbers2.Except(numbers3);
            ////foreach(var num in newList)
            ////{
            ////    Console.WriteLine(num);
            ////}

            #endregion

            #region Join, GroupJoin(left outer join)

            //var q55 = sts.Join(
            //    depts,
            //    s => s.DeptId,
            //    d => d.Id,
            //    (std, dept) => new { 
            //        StudentName = $"{std.Fname} {std.Lname}",
            //        DepartmentName = dept.Name,
            //        Location = dept.Location,
            //    }
            //);

            //foreach(var resultSet in q55)
            //{
            //    Console.WriteLine(resultSet);
            //}

            #endregion

            #region aggregate
            //int[] arr = [1, 2, 3, 4, 5];
            //var q56 = arr.Aggregate((x, y) => x + y);
            //var q57 = arr.Aggregate((x, y) => x * y);
            //Console.WriteLine(q57);
            #endregion
        }
    }
}
