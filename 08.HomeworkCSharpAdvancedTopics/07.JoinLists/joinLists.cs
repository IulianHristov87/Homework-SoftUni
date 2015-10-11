using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.JoinLists
{
    class joinLists
    {
        static void Main()
        {
            Console.WriteLine("Please enter first list of numbers");
            string first = Console.ReadLine();
            Console.WriteLine("Please enter second list of numbers");
            string second = Console.ReadLine();
            List<string> list1 = new List<string>(first.Split(' '));
            List<string> list2 = new List<string>(second.Split(' '));
            List<int> numbers = new List<int>();
            
                for (int i = 0; i < list2.Count; i++)
                {
                    list1.Add(list2[i]);
                }

                for (int y = 0; y < list1.Count; y++)
                {
                    numbers.Add(int.Parse(list1[y]));
                }

                    numbers.Sort();
                    int index = 0;
                    while (index < numbers.Count - 1)
                    {
                        if (numbers[index] == numbers[index + 1])
                        {
                            numbers.RemoveAt(index);
                        }

                        else
                        {
                            index++;
                        }
                            
                    }

            for (int x = 0; x < numbers.Count; x++)
            {
                Console.Write(numbers[x] + " ");
            }
                Console.WriteLine();

        }
    }
}
