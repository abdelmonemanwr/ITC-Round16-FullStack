namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sts = new List<Student>()
            {
                new Student (){Id = 2, Age=21, Fname="Ahmed", Lname="Mohamed"},
                new Student (){Id = 3, Age=19, Fname="Malak", Lname="Tamer"},
                new Student (){Id = 1, Age=20, Fname="Shahd", Lname="Ahmed"},
                new Student (){Id = 6, Age=23, Fname="Saleh", Lname="Selim"},
                new Student (){Id = 4, Age=22, Fname="Toka", Lname="Ali"},
                new Student (){Id = 5, Age=20, Fname="Sagda", Lname="Mahmoud"},
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

            var q36 = sts.Where(s => s.Age >= 31)
                           .DefaultIfEmpty(new Student() { Id = 55, Fname = "test" })
                           .First();
            Console.WriteLine(q36);
            
            #endregion
        }
    }
}
