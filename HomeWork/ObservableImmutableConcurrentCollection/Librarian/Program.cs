using System.Collections.Concurrent;

namespace Otus.HomeWork.Librarian
{
    public class Program
    {
        static void Main(string[] args)
        {
            var librrary = new Librrary();

            var command = new Dictionary<ConsoleKey, ICommandOperation>
            {
                { ConsoleKey.D1, new CommandAdding(librrary) },
                { ConsoleKey.D2, new CommandView(librrary) }
            };
            
            var librarian = new Librarian(librrary, command);

            librarian.Execute($"\n1 - Добавить книгу\n2 - Вывести список непрочитанног\n3 - Выйти\n");
        }
    }
}