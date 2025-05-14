using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPortalExercise.Entities
{
    internal class Student
    {
        public int ID { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Student student &&
                   ID == student.ID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ID);
        }
    }
}
