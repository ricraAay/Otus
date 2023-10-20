namespace Otus.HomeWork.Librarian
{
    public class Librarian
    {
        private readonly Librrary _library;

        private readonly Dictionary<ConsoleKey, ICommandOperation> _command;

        public Librarian(Librrary library, Dictionary<ConsoleKey, ICommandOperation> command)
        {
            _library = library;
            _command = command;
        }

        public void Execute(string menu)
        {
            Console.WriteLine(menu);

            var key = Console.ReadKey().Key;

            if (_command.ContainsKey(key))
            {
                _command[key].Execute();
            }

            if (key == ConsoleKey.D3)
            {
                Environment.Exit(0);
            }

            Execute(menu);
        }
    }
}
