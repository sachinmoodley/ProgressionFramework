using System;

namespace Generics
{
    public class GenericClass<T>
    {
        public void GenericMethod<T>(T input)
        {
            Console.WriteLine(input);
        }
    }
}