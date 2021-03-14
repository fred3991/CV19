using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CV19.Models.Decanat
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthday { get; set; }

        public double Rating { get; set; }

        public string Descripription { get; set; }

    }

    internal class Group
    {
        public string GroupName { get; set; }
        public ICollection<Student> Students { get; set; }

        public string Descripription { get; set; }
    }
}
