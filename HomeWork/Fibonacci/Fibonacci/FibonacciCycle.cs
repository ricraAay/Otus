namespace Otus.HomeWork.Fibonacci
{
    public class FibonacciCycle : IFibonacci
    {
        public FibonacciCycle() {}

        public int Execute(int n)
        {
            int n1 = 1;
            int n2 = 1;

            for (var i = 3; i <= n; i++)
            {
                int n3 = n1 + n2;

                n1 = n2;
                n2 = n3;
            }

            return n2;
        }
    }
}
