using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThursdayWithStas
{
    class Truck : BluePrint
    {

        private string _truckEngineSound = "Bruwm bruwm"; 
        public Truck(string vinNumber, string licenseNumber, int price)
        {
            VinNumber = vinNumber;
            LicenseNumber = licenseNumber;
            ModelName = " FH16";
            Color = "White";
            NumberOfWheel = 4;
            Price = price;
            Engine Engine = new Engine("bruwm bruwm");

            for (int i = 0; i < NumberOfWheel; i++)
            {
                new Wheels();
            }

        }


        public Truck(string vinNumber, string licenseNumber, int price,string model, string color)
        {

            VinNumber = vinNumber;
            LicenseNumber = licenseNumber;
            ModelName = model;
            Color = color;
            NumberOfWheel = 4;
            Engine Engine = new Engine("bruwm bruwm");

            for (int i = 0; i < NumberOfWheel; i++)
            {
                new Wheels();
            }

        }



    }
}
