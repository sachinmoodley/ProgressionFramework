using System;

namespace Interfaces
{
    class Program
    {
        //make a diff car an another function to print both cars that uses ICar
        //write eg of explicitly implementing an interface
        //https://www.geeksforgeeks.org/c-sharp-explicit-interface-implementation/
        static void Main(string[] args)
        {
            var ferrari = new Ferrari();
            Console.WriteLine("Ferrari Specs is:");
            Console.WriteLine("Max Kilowatts is : " + ferrari.MaxKilowatts(500));
            Console.WriteLine("Engine Size is : " + ferrari.Motor(4.5));
        }
    }
}
