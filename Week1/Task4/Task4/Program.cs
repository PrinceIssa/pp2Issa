using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp2
{
    class Program
    {
        static void solve()
        {
            int n;//variable n - number of rows, and also number of stars in the LAST line
            n = Convert.ToInt32(Console.ReadLine());//reading n
            char[,] matrix = new char[n, n * 3];//declaring 2D array, n rows, n * 3 columns,
            //because we need [*] - 3 symbols for each column
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n * 3; j += 3)//we already consireded j + 1, j, also j + 2 will be considered in next step
                                                  //so we can go to j + 3
                                                  //we're interested only in stars positions.
                {
                    //setting middle - star, then in both sides its brackets [ and ]
                    matrix[i, j - 1] = '[';
                    matrix[i, j] = '*';
                    matrix[i, j + 1] = ']';
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (i + 1) * 3; j++)//we have to print n stars in n-th row, thats why j < (i + 1) * 3
                {
                    Console.Write(matrix[i, j]);//writing answer
                }
                Console.WriteLine();//new line after each row
            }

        }
        static void Main(string[] args)
        {
            solve();//calling function solve
            Console.ReadKey();//reading key, analog of system("pause")
        }
    }
}
