using System;

namespace Problem2.SortArrayUsingSelectionSort
{
    class SortArrayOfNumbersUsingSelectionSort
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputClear = input.Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int[] numbersForSort = Array.ConvertAll(inputClear,int.Parse);
            int arrayLenght = numbersForSort.Length;

            int[] result = new int[arrayLenght];

            

            for (int x = 0; x < arrayLenght - 1; x++)
            {
                int minNumber=0;
                int count = 0;
                if (numbersForSort[x] < minNumber)
                {
                
                }
                
            }

            for (int i = 0; i < inputClear.Length; i++)
            {
                Console.Write(result[i] + " ");
            }

            Console.WriteLine();
        }
        
    }
}
