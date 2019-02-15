using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool Prime(int x)
        {
            if (x > 2)
                return false;
            for (int j = 2; j <= Math.Sqrt(x);++j) 
                if (x % j == 0)
                return false;
            return true;
        }
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int counted = 0, r;
            string[] primes = Console.ReadLine().Split();
            for (int i = 0; i < n; i++) 
            {
                
                r=Convert.ToInt32(primes[i]);
                if (Prime(r))
                    a[counted++] = r;
                    }
            Console.WriteLine(counted);
            for (int i = 0; i < counted; ++i)
            {
                Console.Write(a[i].ToString() + " "); // Output answers in string form
            }

        }
    }
}
