using System;

namespace SwapFirstLastCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen string ifadeleri girin (örneğin: Merhaba Hello Algoritma x):");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(SwapFirstLastCharacter(words[i]) + " ");
            }

            Console.WriteLine("\nDevam etmek için bir tuşa basın...");
            Console.ReadKey();
        }

        static string SwapFirstLastCharacter(string word)
        {
            if (word.Length <= 1)
                return word;

            char firstChar = word[0];
            char lastChar = word[word.Length - 1];
            string middlePart = word.Substring(1, word.Length - 2);

            return lastChar + middlePart + firstChar;
        }
    }
}
