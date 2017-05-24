using System;

namespace Add_Two_Numbers
{
    class Add_Two_Numbers
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");
        }
    }
}