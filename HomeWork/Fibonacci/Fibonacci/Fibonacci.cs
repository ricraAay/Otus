using System.Diagnostics;

namespace Otus.HomeWork.Fibonacci
{
    public class Fibonacci
    {
        private readonly IFibonacci _fibonacci;

        private readonly Stopwatch _stopwatch;

        public Fibonacci(IFibonacci fibonacci)
        {
            this._fibonacci = fibonacci;
            this._stopwatch = new Stopwatch();
        }

        public void Execute(int n)
        {

            this._stopwatch.Start();

            var result = this._fibonacci.Execute(n);

            this._stopwatch.Stop();

            Console.WriteLine($"Входное значение: {n}\nЧисло фибоначи: {result}\nВремя выполнения: {this._stopwatch.Elapsed.Microseconds} мк.сек\n");

            this._stopwatch.Reset();
        }
    }
}
