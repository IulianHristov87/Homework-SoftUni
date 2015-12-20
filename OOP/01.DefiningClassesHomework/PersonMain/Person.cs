using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonMain
{
    class Person
    {
        public string name;
        public int age;
        public string eMail;
        public const int MinAlowwedYears = 1;
        public const int MaxAlowwedYears = 100;

        public Person(string name, int age, string eMail)
        {
            this.Name = name;
            this.Age = age;
            this.Email = eMail;
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || value == String.Empty || value.Length < 3)
                {
                    throw new ArgumentException("Name cannot be at least 3 symbols");
                }

                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value > MaxAlowwedYears || value < MinAlowwedYears)
                {
                    throw new ArgumentException ("Age must be in range 1 to 100");
                }

                this.age = value;
            }
        }
        public string Email
        {
            get
            {
                return this.eMail;
            }
            set
            {
                if (value.Contains("@") || value == null)
                {
                    this.eMail = value;
                }
                else
                {
                    throw new ArgumentException("Email isnt in correct format");
                }
            }
        }

        public static void ToString(Person person)
        {
            Console.WriteLine("Name: {0}", person.Name);
            Console.WriteLine("Age: {0}", person.Age);
            Console.WriteLine("Email: {0}", person.Email);
        }
    }
}
