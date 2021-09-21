using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("asd", "asd", 12, "asd", 12, "KN-P-192");
            AcademyGroup group = new AcademyGroup();
            group.AddStudent(st);
            group.PrintGroup();
            group.EditStudent("asd");
            group.PrintGroup();
        }
    }
}
