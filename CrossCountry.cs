using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThursdayWithStas
{
    class CrossCountry : BluePrint
    {
        public CrossCountry(string vinNumber, string licenseNumber, int price)
        {
            VinNumber = vinNumber;
            LicenseNumber = licenseNumber;
            ModelName = " XC60 ";
            Color = "White";
            NumberOfWheel = 4;
            Price = price;
            Engine Engine = new Engine("Browm Vroom");

            for (int i = 0; i < NumberOfWheel; i++)
            {
                new Wheels();
            }

        }


        public CrossCountry(string vinNumber, string licenseNumber, int price, string model, string color)
        {

            VinNumber = vinNumber;
            LicenseNumber = licenseNumber;
            ModelName = model;
            Price = price;
            Color = color;
            NumberOfWheel = 4;
            Engine Engine = new Engine("Browm Vroom");

            for (int i = 0; i < NumberOfWheel; i++)
            {
                new Wheels();
            }

        }
    }
}
