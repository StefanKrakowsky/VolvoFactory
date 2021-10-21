using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThursdayWithStas
{
    class Electric : BluePrint
    {

        public Electric(string vinNumber, string licenseNumber, int price)
        {
            VinNumber = vinNumber;
            LicenseNumber = licenseNumber;
            ModelName = " v90E ";
            Color = "White";
            NumberOfWheel = 4;
            Price = price;
            Engine Engine = new Engine("ssss");

            for (int i = 0; i < NumberOfWheel; i++)
            {
                new Wheels();
            }

        }


        public Electric(string vinNumber, string licenseNumber, int price, string model, string color)
        {

            VinNumber = vinNumber;
            LicenseNumber = licenseNumber;
            ModelName = model;
            Color = color;
            NumberOfWheel = 4;
            Engine Engine = new Engine("sss");

            for (int i = 0; i < NumberOfWheel; i++)
            {
                new Wheels();
            }

        }
    }
}
