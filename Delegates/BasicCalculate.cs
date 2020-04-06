namespace Delegates
{
    //do a simple calculate 
    //remove calc delegate
    //use log as your delegate
    public class BasicCalculate
    {
        public delegate void log(string message);

        public void doSomeWork(log log)
        {
            log("Success");
        }

        public void Add(int firstNumber, int secondNumber, log log)
        {
            var sum = firstNumber + secondNumber;
            log($"Your total is {sum}");
        }

        public void Subtract(int firstNumber, int secondNumber, log log)
        {
            var sum = firstNumber - secondNumber;
            log($"Your total is {sum}");
        }
    }
}
