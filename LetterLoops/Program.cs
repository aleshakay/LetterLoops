using System;
using System.Text;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a string - ");
            string inputed = Console.ReadLine();
            string result = String.Empty;
            for (int i = 0; i < inputed.Length; i++)
            {
                char c = inputed[i];
                result += char.ToUpper(c);
                result += new String(char.ToLower(c), i);
                if (i < inputed.Length - 1)
                {
                    result += "-";
                }
            }
            Console.WriteLine(result);
        }
    }
}
