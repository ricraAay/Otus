using System.Collections.Immutable;
using System.IO;
using System.Text;

namespace Otus.HomeWork.Home
{
    public class Program
    {
        static void Main(string[] args)
        {
            var part1 = new Part1();
            var part2 = new Part2();
            var part3 = new Part3();
            var part4 = new Part4();
            var part5 = new Part5();
            var part6 = new Part6();
            var part7 = new Part7();
            var part8 = new Part8();
            var part9 = new Part9();

            part1.AddPart(ImmutableList.Create<string>());
            part2.AddPart(part1.Poem);
            part3.AddPart(part2.Poem);
            part4.AddPart(part3.Poem);
            part5.AddPart(part4.Poem);
            part6.AddPart(part5.Poem);
            part7.AddPart(part6.Poem);
            part8.AddPart(part7.Poem);
            part9.AddPart(part8.Poem);


            Console.WriteLine($"{string.Join("\n", part1.Poem)}\n");
            Console.WriteLine($"{string.Join("\n", part2.Poem)}\n");
            Console.WriteLine($"{string.Join("\n", part3.Poem)}\n");
            Console.WriteLine($"{string.Join("\n", part4.Poem)}\n");
            Console.WriteLine($"{string.Join("\n", part5.Poem)}\n");
            Console.WriteLine($"{string.Join("\n", part6.Poem)}\n");
            Console.WriteLine($"{string.Join("\n", part7.Poem)}\n");
            Console.WriteLine($"{string.Join("\n", part8.Poem)}\n");
            Console.WriteLine($"{string.Join("\n", part9.Poem)}\n");
        }
    }
}