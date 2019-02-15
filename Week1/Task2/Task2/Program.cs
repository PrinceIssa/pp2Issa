using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    struct Information
    {

        public int ID;
        public string name;
        public int YearsOFStudy;
        public string Surname;


        void DisplayInfo()
        {
            Console.WriteLine($"name={name} ID={ID} Years of study={YearsOFStudy} Surname={Surname}");
        }
        class Program
        {
            static void Main(string[] args)
            {
                Information info;
                info.name = "Issa";
                info.ID = 123242;
                info.YearsOFStudy = 2019;
                info.Surname = "Syrymuly";

                info.DisplayInfo();


            }

        }
    }
}
