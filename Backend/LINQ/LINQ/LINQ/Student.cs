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
        public int DeptId { get; set; } 
        public List<Course> Courses { get; set; }
        public Student()
        {
            
        }
        public Student(int id, string fname, string lname, int age, List<Course> courses)
        {
            Id = id;
            Fname = fname;
            Lname = lname;
            Age = age;
            Courses = courses;
        }

        public override string ToString()
        {
            return $"Id = {Id}, FName = {Fname}, Lname = {Lname}, Age = {Age}";
        }

    }
}
