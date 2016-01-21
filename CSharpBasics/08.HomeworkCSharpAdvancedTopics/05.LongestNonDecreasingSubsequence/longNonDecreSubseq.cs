using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LongestNonDecreasingSubsequence
{
    class longNonDecreSubseq
    {
        static void Main()
        {
            Console.WriteLine("Please enter first list of numbers");
            string numbersInput = Console.ReadLine();
            List<string> listOfNumbers = new List<string>(numbersInput.Split(' '));
            List<int> listOfNumbInt = new List<int>();
            for (int i = 0; i < listOfNumbers.Count; i++ )
            {
                listOfNumbInt.Add(int.Parse(listOfNumbers[i]));
            }
            for (int x = 0; x < listOfNumbInt.Count - 1; x++)
            {
            }
            
            for (int z = 0; z < listOfNumbInt.Count; z++)
            {
                Console.Write(listOfNumbInt[z]+" ");
            }
        }
    }
}
