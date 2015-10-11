using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RemoveNames
{
    class removeNames
    {
        static void Main()
        {
            Console.WriteLine("Please enter first list");
            string first = Console.ReadLine();
            Console.WriteLine("Please enter second list");
            string second = Console.ReadLine();
            List<string> list1 = new List<string> (first.Split(' '));
            List<string> list2 = new List<string>(second.Split(' '));

            for (int i = 0; i < list1.Count; i++)
            {
                foreach (var item in list2)
                {
                    list1.Remove(item);
                }
                Console.Write(list1[i] + " ");
            }
            Console.WriteLine();
            
        }
    }
}
