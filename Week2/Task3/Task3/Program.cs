
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.getAllFiles(@"C:\Users\Иса Бизнесмен\source\repos\Issa\ex1\ex1");

        }

        public void getAllFiles(string directoryPath)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(directoryPath);
            FileInfo[] files = dirInfo.GetFiles();
            foreach (FileInfo f in files)
            {
                Console.WriteLine(f.FullName);
            }

            Console.ReadLine();
        }

    }
}