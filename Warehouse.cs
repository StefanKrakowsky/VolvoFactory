using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThursdayWithStas
{
    class Warehouse
    {

        public List<BluePrint> CarInventory;

        public void PrintInventory()
        {
            Console.WriteLine($"Car Inventory ");

            foreach (BluePrint item in CarInventory)
            {
                Console.WriteLine($"Model: {item.ModelName, -20} Price: {item.Price} ");
                
            }
        }

        public Warehouse()
        {
            CarInventory = new List<BluePrint>()
        {
            new Truck("4Y1SL65848Z411439", "SEF83R", 1500000),
            new Sedan("8T35L65848Z411439", "JSR91G", 500000),
            new CrossCountry("L98L65848Z411439", "LJJ73T", 800000),
            new Electric("35FSL65848Z411439", "REP42C", 700000),
            new Sedan("35FSL65848Z411439", "UWW83D", 630000)
        };



        }


        public void AddToInventory(BluePrint CarToAdd)
        {
            CarInventory.Add(CarToAdd);
        }

        public void SortListByPrice()
        {
            List<BluePrint> SortedList = CarInventory.OrderByDescending(obj => obj.Price).ToList(); // Creating a new list of (listBluePrint), ordering them by descending to the new list
            CarInventory = SortedList;
        }

        public void SortListByName()
        {
            List<BluePrint> SortedList = CarInventory.OrderBy(obj => obj.ModelName).ToList();

        }




    }



}
