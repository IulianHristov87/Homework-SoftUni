using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonMain
{
    class PersonMain
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person("Ivan Ivanov Ivanov", 28, "ivanivanov000@abv.bg");
            Person newPerson1 = new Person("Dragan Petrov Ivanov", 28);
            Person.ToString(newPerson);
            Console.WriteLine();
            Person.ToString(newPerson1);
        }
    }
}
