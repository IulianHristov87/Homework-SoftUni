using System;
using System.Collections.Generic;

public class DecryptTheMessages
{
    public static void Main()
    {
        Dictionary<char, char> specialSymbols = new Dictionary<char, char>
        {
            {'+', ' '},
            {'%', ','},
            {'&', '.'},
            {'#', '?'},
            {'$', '!'}
        };

        List<string> decryptedMessages = new List<string>();

        string command = Console.ReadLine();

        while (command != "start" && command != "START")
        {
            command = Console.ReadLine();
        }

        command = Console.ReadLine();

        while (command != "end" && command != "END")
        {
            if (string.IsNullOrWhiteSpace(command))
            {
                command = Console.ReadLine();
                continue;
            }

            char[] symbols = command.ToCharArray();

            for (int i = 0; i < symbols.Length; i++)
            {
                char currentSymbol = symbols[i];

                if (specialSymbols.ContainsKey(currentSymbol))
                {
                    symbols[i] = specialSymbols[currentSymbol];
                }
                else if (('a' <= currentSymbol && currentSymbol <= 'm') || ('A' <= currentSymbol && currentSymbol <= 'M'))
                {
                    symbols[i] = (char)(currentSymbol + 13);
                }
                else if (('n' <= currentSymbol && currentSymbol <= 'z') || ('N' <= currentSymbol && currentSymbol <= 'Z'))
                {
                    symbols[i] = (char)(currentSymbol - 13);
                }
            }

            Array.Reverse(symbols);

            decryptedMessages.Add(new string(symbols));

            command = Console.ReadLine();
        }

        if (decryptedMessages.Count == 0)
        {
            Console.WriteLine("No message received.");
        }
        else
        {
            Console.WriteLine("Total number of messages: {0}", decryptedMessages.Count);

            foreach (var decryptedMessage in decryptedMessages)
            {
                Console.WriteLine(decryptedMessage);
            }
        }
    }
}
