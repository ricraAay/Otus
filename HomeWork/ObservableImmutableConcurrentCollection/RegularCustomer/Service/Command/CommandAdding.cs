namespace Otus.HomeWork.RegularCustomer
{
    public class CommandAdding : ICommandOperation
    {
        private readonly Shop _shop;

        public CommandAdding(Shop shop)
        {
            _shop = shop;
        }

        public void Execute()
        {
            _shop.Add($"Товар от {DateTime.Now}");
        }
    }
}
