using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = "";
            for (int i = s1.Length - 1; i >= 0; i = i - 1)
            {
                s2 = s2 + s1[i];
            }
            if (s1 == s2)
            {
                Console.WriteLine("Your string is palindrome");
            }
            else
            {
                Console.WriteLine("Your string is not palindrome");
            }
        }
    }
}
