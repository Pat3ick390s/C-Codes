using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetOperators
{
    internal class Student : IEquatable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public bool Equals(Student? other)
        {
           if (Object.ReferenceEquals(other,null))
           {
                return false;
           }
           if (Object.ReferenceEquals (this, other))
           {
                return true;
           }
           return Id.Equals(other.Id) && Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            int IdHashCode = Id.GetHashCode();
            int NameHashCode = Name.GetHashCode();

            return IdHashCode ^ NameHashCode;
        }

        
    }

    internal class Student1:IEqualityComparer<Student1>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Equals(Student1? x, Student1? y)
        {
            return x.Id.Equals(y.Id) && x.Name.Equals(y.Name);
        }

        public int GetHashCode( Student1 obj)
        {
            int IdHashCode = obj.Id.GetHashCode();
            int NameHashCode = obj.Name.GetHashCode();

            return IdHashCode ^ NameHashCode;
        }
    }
}
