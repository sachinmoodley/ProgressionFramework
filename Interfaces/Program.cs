using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var ferrari = new Ferrari();
            Console.WriteLine("Ferrari Specs is:");
            Console.WriteLine("Max Kilowatts is : " + ferrari.MaxKilowatts(500));
            Console.WriteLine("Engine Size is : " + ferrari.Motor(4.5));
        }
    }
}
