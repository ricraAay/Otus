namespace Otus.HomeWork.LinqOperation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int>() { 100, 2, 3, 4, 5, 6, 7, 444, 9 };

            foreach (var value in intList.Top(33))
            {
                Console.WriteLine(value);
            }

            var personList = new List<Person>()
            {
                new Person("Годжо Сатору", 30),
                new Person("Зенин Маки", 22),
                new Person("Рёмен Сукуна", 1523),
                new Person("Итадори Юдзи", 17),
                new Person("Ханами", 400),
                new Person("Тодо Аой", 24),
                new Person("Фушигуро Мегуми", 19),
                new Person("Оккоцу Юта", 21),
                new Person("Фушигуро Тодзи", 43),
            };

            foreach (var value in personList.Top(33, person => person.Age))
            {
                Console.WriteLine($"name: {value.Name}, age: {value.Age}");
            }

        }
    }


}