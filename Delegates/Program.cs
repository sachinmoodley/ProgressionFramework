using System;
using static Delegates.Geeks;

namespace Delegates
{

    //example taken from https://www.geeksforgeeks.org/c-sharp-delegates/
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Geeks();

            addnum del_obj1 = new addnum(obj.sum);
            subnum del_obj2 = new subnum(obj.subtract);

            del_obj1(100, 40);
            del_obj2(100, 60);

            //Console.WriteLine(del_obj1.Invoke(100, 40));
        }
    }
}
