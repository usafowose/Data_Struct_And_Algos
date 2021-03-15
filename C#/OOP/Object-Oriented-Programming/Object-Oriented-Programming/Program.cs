using System;
using All_My_Classes; 

namespace Object_Oriented_Programming
{
    class Program
    {
        
        static void UseBasicMachine() 
        {
            BasicCoffeeMaker QuickBrew = new BasicCoffeeMaker("QuickBrew", "Columbia Bean", "Heavy Cream", 8);
            Console.WriteLine(QuickBrew.Brew());
            Console.WriteLine(QuickBrew.PourDrink());
            
        }

        static void UseAdvancedMachine() 
        {
            AdvancedCoffeeMaker KatoMachine3000 = new AdvancedCoffeeMaker("Kato3000", "Vanilla Bean", "Heavy Cream", "Whipped Cream", 8);
            Console.WriteLine("------------------------------");
            Console.WriteLine(KatoMachine3000.Brew());
            Console.WriteLine(KatoMachine3000.Brew("Quick"));
            Console.WriteLine(KatoMachine3000.Brew("Fast", 16));
            Console.WriteLine(KatoMachine3000.Update());
            Console.WriteLine(KatoMachine3000.PourDrink());
        }
        static void Main(string[] args)
        {
            UseBasicMachine();
            UseAdvancedMachine();
        }
    }
}
