namespace Otus.HomeWork.OtusDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var otusDictionary = new OtusDictionary();

            // Заполнение коллекции
            otusDictionary.Add(1, "Hello");             // HashCode = 1
            otusDictionary.Add(2, "OTUS");              // HashCode = 2
            otusDictionary[33] = "!";                   // HashCode = 1

            // Получение значений
            var valueFirst = otusDictionary.Get(1);     // Value = "Hello"
            var valueSecond = otusDictionary.Get(2);    // Value = "OTUS"
            var valueThird = otusDictionary.Get(33);    // Value = "!"
            var valueNothing = otusDictionary.Get(56);  // Value = null

            Console.WriteLine($"valueFirst: {valueFirst}\nvalueSecond: {valueSecond}\nvalueThird: {valueThird}\nvalueNothing: {valueNothing}");
        }
    }
}