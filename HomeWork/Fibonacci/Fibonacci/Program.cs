namespace Otus.HomeWork.Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fibonacciRecursion = new Fibonacci(new FibonacciRecursion());
            var fibonacciCycle = new Fibonacci(new FibonacciCycle());

            fibonacciRecursion.Execute(10);
            fibonacciRecursion.Execute(20);
            fibonacciRecursion.Execute(5);

            fibonacciCycle.Execute(5);
            fibonacciCycle.Execute(10);
            fibonacciCycle.Execute(20);
        }
    }
}