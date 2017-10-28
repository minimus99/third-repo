using System;

namespace Problem_3._Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine("Hello World!");
          string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
          int  employeeId= int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {employeeId:D8}");//D служи за това клко нули искаме да видим пред числото,все едно имаме оселм квадрчатчета в кото  се запълва числото тоест ако е двет цифрено няма да има нули
            Console.WriteLine($"Salary: {salary:F2}");



        }
    }
}
