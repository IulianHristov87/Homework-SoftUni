using System;
using System.Collections.Generic;
using System.Linq;

class ArrayManipulator
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('\\');

        char[] firstArr = input[0].ToCharArray();
        char[] secondArr = input[1].ToCharArray();
        string command = input[2];

        List<char> newArr = new List<char>();

        if (command == "join")
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (secondArr.Contains(firstArr[i]))
                {
                    newArr.Add(firstArr[i]);
                }
            }
        }
        else if (command == "right exclude")
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (!secondArr.Contains(firstArr[i]))
                {
                    newArr.Add(firstArr[i]);
                }
            }
        }
        else
        {
            for (int i = 0; i < secondArr.Length; i++)
            {
                if (!firstArr.Contains(secondArr[i]))
                {
                    newArr.Add(secondArr[i]);
                }
            }
        }


        newArr.Sort();
        foreach (var el in newArr)
        {
            Console.Write(el);
        }
    }
}
