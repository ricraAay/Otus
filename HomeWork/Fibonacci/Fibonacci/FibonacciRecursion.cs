namespace Otus.HomeWork.Fibonacci
{
    public class FibonacciRecursion : IFibonacci
    {
        public FibonacciRecursion() {}

        public int Execute(int n)
        {
            return n == 0 || n == 1 ? n : (Execute(n - 1) + Execute(n - 2));
        }
    }
}
