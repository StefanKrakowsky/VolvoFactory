using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThursdayWithStas
{
    abstract class BluePrint
    {
        protected  string VinNumber { get; init; }
        protected  string LicenseNumber { get; init; }
        public  string ModelName { get; init; }

        protected  int NumberOfWheel { get;  set; }

        protected  string Color { get; init; }

        public int Price { get; init; }





    }
}
