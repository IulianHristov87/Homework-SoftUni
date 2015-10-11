using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.SumOfElements
{
    class sumOfElements
    {
        static void Main()
        {
            string userInput = Console.ReadLine();
            string[] numbers = userInput.Split(' ');
            long start = int.Parse(numbers[0]);
            long bigger = 0;
            long sum = 0;
            

            for (int i = 0; i < numbers.Length; i++)
            {
                if(int.Parse(numbers[i]) > start)
                {
                    bigger = int.Parse(numbers[i]);
                    start = int.Parse(numbers[i]);
                }
                else if(start > int.Parse(numbers[i]))
                {
                    bigger = start;
                }
                else if(start == int.Parse(numbers[i]))
                {
                    bigger = int.Parse(numbers[i]);
                }
            }
            for (int x = 0; x < numbers.Length; x++)
            {
                sum += int.Parse(numbers[x]);
               
                
            }

            long finalSum = sum - bigger;

            long diff = Math.Abs(bigger - finalSum);

            if (diff == 0)
            {
                Console.WriteLine("Yes, sum={0}", finalSum);
            }
            else
            {
                Console.WriteLine("No, diff={0}", diff);
            }
            
        }
    }
}
