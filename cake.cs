using System;

namespace VII_Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        { 
            string product = Console.ReadLine();
            int counter = 0;
            while (product != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {product}");
                product = Console.ReadLine();//въвеждане на нова стойност но без  да се изпсисва string
                counter++;
            }
            Console.WriteLine($"Preparing cake with {product} ingredients.");
        }
    }
}
