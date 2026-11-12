
using System.Diagnostics.CodeAnalysis;

namespace LINQ
{
    internal class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student? x, Student? y)
        {
            return x?.Id == y?.Id && x?.Age == y?.Age;
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            return HashCode.Combine(obj.Id, obj.Age);
        }
    }
}