using System;

namespace ThursdayWithStas
{
    class Program
    {
        static void Main(string[] args)
        {
            Warehouse myWarehouse = new Warehouse();
            myWarehouse.PrintInventory();

            BluePrint car1 = new CrossCountry("9CSWSL65848Z411439", "ABV84E", 889000, "XC90", "Metallic Black");
            BluePrint car2 = new Sedan("HAL2L65848Z411439", "JGL39C", 863000, "S90", "Grey");

            myWarehouse.AddToInventory(car1);
            myWarehouse.AddToInventory(car2);
            myWarehouse.PrintInventory();
            myWarehouse.SortListByPrice();
            myWarehouse.PrintInventory();
            Console.WriteLine("");
            myWarehouse.SortListByName();
            myWarehouse.PrintInventory();


        }
    }
}
