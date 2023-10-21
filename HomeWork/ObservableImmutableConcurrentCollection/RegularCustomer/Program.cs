namespace Otus.HomeWork.RegularCustomer
{
    public class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();
            var customer = new Customer();
            var commands = new Dictionary<ConsoleKey, ICommandOperation>
            {
                { ConsoleKey.A, new CommandAdding(shop) },
                { ConsoleKey.D, new CommandRemoval(shop) },
                { ConsoleKey.X, new CommandExit() }
            };

            var regularCustomer = new RegularCustomer(commands);

            shop.Items.CollectionChanged += customer.OnItemChanged;

            Console.WriteLine("A - добавить товар\nD - удалить товар\nX - выход из программы\n");

            regularCustomer.Execute();
        }
    }
}