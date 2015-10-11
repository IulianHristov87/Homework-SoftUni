using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LongestWordInAText
{
    class longestWordInAText
    {
        static void Main()
        {
            Console.WriteLine("Please enter text");
            string text = Console.ReadLine();
            char[] separators = { ' ', '.', ',' };
            List<string> splitedText = text.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            string longestWord = string.Empty;

            for (int i = 0; i < splitedText.Count; i++)
            {
                if (splitedText[i].Length >= longestWord.Length)
                {
                    longestWord = splitedText[i];
                }
            }
            Console.WriteLine(longestWord);
        }
    }
}
