using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down the number of arrays: ");//output 

            int n = int.Parse(Console.ReadLine());//int n   
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("the repeat of massive for two times: ");
            for (int i = 0; i < n; i++)
            {
                for (int a = 0; a < 2; a++) Console.Write(array[i] + " ");


            }
            Console.WriteLine();


        }
    }
}
