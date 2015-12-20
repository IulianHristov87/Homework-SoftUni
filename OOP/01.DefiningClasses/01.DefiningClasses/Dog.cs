using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DefiningClasses
{
    class Dog
    {
        public Dog()
        {
        }
        public Dog(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
            
        }
        public string Name { get; set; }
        public string Breed { get; set; }
        public void Bark()
        {
            Console.WriteLine("{0} ({1}) said: Bauuuuu!", this.Name ?? "[unnamed dog]", this.Breed ?? "[unknow breed]");
        }
        public static void Main()
        {
            Dog unnamed = new Dog();
            Dog reks = new Dog("Reksi", "Divak");

            unnamed.Breed = "German Shepherd";

            unnamed.Bark();
            reks.Bark();
        }
    }
}
