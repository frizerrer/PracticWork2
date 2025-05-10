using System;

namespace ComputerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Computer comp = new Computer(123345, 1.5, 400);

            
            comp.ShowInfo();

           
            double pricePerGB = 100;
            double totalCost = comp.CalculateMemoryCost(pricePerGB);
            Console.WriteLine("Стоимость внешней памяти: " + totalCost + " рублей");

            Console.ReadLine();
        }
    }
}
