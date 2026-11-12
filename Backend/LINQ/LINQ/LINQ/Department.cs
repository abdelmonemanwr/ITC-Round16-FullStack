namespace LINQ
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public Department()
        {

        }

        public Department(int id, string name, string location)
        {
            Id = id;
            Name = name;
            Location = location;
        }

        public override string ToString()
        {
            return $"Id = {Id}, DeptName = {Name}, DeptLoc = {Location}";
        }
    }
}