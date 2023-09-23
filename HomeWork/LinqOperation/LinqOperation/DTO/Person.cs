namespace Otus.HomeWork.LinqOperation
{
    public class Person
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
