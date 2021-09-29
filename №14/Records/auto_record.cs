using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Tom", 36);
            Console.WriteLine(person.Name); // Tom

            var (userName, userAge) = person;

            Console.WriteLine(userAge);     // 36
            Console.WriteLine(userName);    // Tom
        }
    }
    public record Person(string Name, int Age);
    //  Для типа Person будет создаваться конструктор, который принимает два параметра и присваивает их значения соответственно свойствам Name и Age, и что также автоматически будет создаваться деконструктор.
}
