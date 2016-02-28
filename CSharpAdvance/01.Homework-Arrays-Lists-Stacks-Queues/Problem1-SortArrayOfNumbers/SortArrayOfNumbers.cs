using System;

namespace Problem1_SortArrayOfNumbers
{
    class SortArrayOfNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputClear = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbersForSort = Array.ConvertAll(inputClear, element => int.Parse(element));
            int arrayLenght = numbersForSort.Length;

            for (int x = 0; x < arrayLenght - 1; x++)
            {
                int exchangeNumber;
                while (numbersForSort[x] > numbersForSort[x+1])
                {
                    
                    exchangeNumber = numbersForSort[x+1];
                    numbersForSort[x+1] = numbersForSort[x];
                    numbersForSort[x] = exchangeNumber;
                }
                for (int y = 0; y < arrayLenght - 1; y++)
                {
                    
                    while (numbersForSort[y] > numbersForSort[y + 1])
                    {

                        exchangeNumber = numbersForSort[y + 1];
                        numbersForSort[y + 1] = numbersForSort[y];
                        numbersForSort[y] = exchangeNumber;
                    }
                }
            }
           
            for (int i = 0; i < numbersForSort.Length; i++)
            {
                Console.Write(numbersForSort[i]+" ");
            }

            Console.WriteLine();


        }
    }
}
