namespace Otus.HomeWork.RegularCustomer
{
    public class RegularCustomer
    {
        private readonly IDictionary<ConsoleKey, ICommandOperation> _commands;

        public RegularCustomer(IDictionary<ConsoleKey, ICommandOperation> commands) 
        {
            _commands = commands;
        }

        public void Execute()
        {
            var key = Console.ReadKey().Key;

            if (_commands.ContainsKey(key))
            {
                _commands[key].Execute();
            }

            Execute();
        }
    }
}
