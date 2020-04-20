namespace Delegates
{
    //do a simple calculate 
    //remove calc delegate
    //use log as your delegate

    // create a class with a method to take in 10 lines of numbers.. that class should have a constructor as a delegate.
    // the delegate should have a behaviour to sort the numbers
    //then return the numbers
    public class BasicCalculate
    {
        public delegate void log(string message);


        public int Add(int firstNumber, int secondNumber, log log)
        {
            var sum = firstNumber + secondNumber;
            log($"Your total is {sum}");
            return sum;
        }

        public int Subtract(int firstNumber, int secondNumber, log log)
        {
            var sum = firstNumber - secondNumber;
            log($"Your total is {sum}");
            return sum;
        }
    }
}
