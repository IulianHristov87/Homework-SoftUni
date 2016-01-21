using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.MinMaxAvgOfNNumbers
{
    class minMaxAvg
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Please enter number n");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int index = 0;
            int max = 0;
            int min = 0;
            double sumOfNumbers = 0;
            
            
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                sumOfNumbers += numbers[i];
            }
            for (int x = 1; x < n ; x++)
            {
                if (numbers[index] < numbers[x] && numbers[x]>max  )
                {
                    max = numbers[x];

                    if(numbers[index] < min)
                    {
                        min = numbers[index];
                    }
                    
                }
                else if (numbers[index] > numbers[x] && numbers[index] > max  )
                {
                    max = numbers[index];

                    if (numbers[x] < min)
                    {
                        min = numbers[x];
                    }
                    
                }
                
                index++;
            }
                double averange = sumOfNumbers/n;
                Console.WriteLine("min = {0}", min);
                Console.WriteLine("max = {0}", max);
                Console.WriteLine("sum = {0}", sumOfNumbers);
                Console.WriteLine("avg = {0:F2}", averange);
        }
    }
}
