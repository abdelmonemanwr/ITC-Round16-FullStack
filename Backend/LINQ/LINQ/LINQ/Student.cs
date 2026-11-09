using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Student
    {

        public required int Id { get; init; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }
        public Student()
        {
            
        }
        public Student(int id, string fname, string lname, int age)
        {
            Id = id;
            Fname = fname;
            Lname = lname;
            Age = age;
        }

        public override string ToString()
        {
            return $"Id = {Id}, FName = {Fname}, Lname = {Lname}, Age = {Age}";
        }

    }
}
