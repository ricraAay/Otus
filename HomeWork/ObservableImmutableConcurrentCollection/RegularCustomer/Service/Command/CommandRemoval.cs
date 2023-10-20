namespace Otus.HomeWork.RegularCustomer
{
    public class CommandRemoval : ICommandOperation
    {
        private readonly Shop _shop;

        public CommandRemoval(Shop shop)
        {
            _shop = shop;
        }

        public void Execute()
        {
            Console.Write(" - Укажите какой товар необходимо удалить: ");

            var value = Console.ReadLine();

            if (int.TryParse(value, out int idx))
            {
                _shop.Remove(idx);
            }
        }
    }
}
