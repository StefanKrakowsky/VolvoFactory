using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThursdayWithStas
{
    class Engine 
    {
        public string _engineSound;

        public Engine(string engineSound)
        {
            _engineSound = engineSound;
        }


        public void StartEngine()
        {
            Console.WriteLine($"Car starts with a {_engineSound}");
        }

        public void CarStops()
        {
            Console.WriteLine($"Car engine has turned off");
        }


    }
}
