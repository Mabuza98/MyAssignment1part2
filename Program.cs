using System;
namespace Assignment1.p2
{
    class Program
    {
        class ReverseString
        {

            static void Main(string[] args)
            {
                string str = "";
                Console.WriteLine("Enter The String");
                string s = Console.ReadLine();

                int len = s.Length;

                for (int j = len - 1; j >= 0; j--)
                {
                    str = str + s[j];
                }
                if (str == s)
                    Console.WriteLine(s + " is palindrome");

                else
                    Console.WriteLine(s + " is not palindrome");

                Console.ReadLine();
            }
        }
    }
}


