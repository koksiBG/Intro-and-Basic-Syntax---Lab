using System;

namespace Employee_Data
{
    class Employee_Data
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            int idNumber = int.Parse(Console.ReadLine());
            double monthlySalary = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {idNumber:D8}");
            Console.WriteLine($"Salary: {monthlySalary:F2}");
        }
    }
}