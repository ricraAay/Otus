namespace Otus.HomeWork.RegularCustomer
{
    public class CommandExit : ICommandOperation
    {
        public void Execute() 
        {
            Environment.Exit(0);
        }
    }
}
