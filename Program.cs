using System;

namespace Problem_2._Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var sum = a + b;
          //  Console.WriteLine(sum);
            Console.WriteLine($"{a} + {b} = {sum}");


        }
    }
}
