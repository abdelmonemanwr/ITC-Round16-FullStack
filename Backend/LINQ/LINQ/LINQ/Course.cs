namespace LINQ
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Hours { get; set; }

        public Course()
        {
            
        }

        public Course(int id, string name, string code, int hours)
        {
            Id = id;
            Name = name;
            Code = code;
            Hours = hours;
        }

        public override string ToString()
        {
            return $"Id = {Id}, CrsName = {Name}, CrsCode = {Code}, CrsHours = {Hours}";
        }
    }
}