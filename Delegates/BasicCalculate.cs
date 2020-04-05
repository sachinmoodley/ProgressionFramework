namespace Delegates
{
    public class BasicCalculate
    {
        public delegate void calculate(int firstNumber, int secondNumber);
        public delegate void log(string message);

        public void doSomeWork(log log)
        {
            log("Success");
        }

        public void Add(calculate calculate)
        {
            calculate(10, 20);
        }

        public void Subtract(calculate calculate)
        {
            calculate(20, 10);
        }
    }
}
