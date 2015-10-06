using System;

namespace _04.PracticeNullableTypes
{
    class Program
    {
        static void Main()
        {
            int? num;
            num = null;
            Console.WriteLine(num);
            num += 42;
            Console.WriteLine(num);
            num = 10;
            Console.WriteLine(num);
        }
    }
}
