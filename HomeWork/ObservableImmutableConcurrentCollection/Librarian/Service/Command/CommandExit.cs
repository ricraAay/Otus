namespace Otus.HomeWork.Librarian
{
    public class CommandExit : ICommandOperation
    {
        public void Execute() 
        {
            Environment.Exit(0);
        }
    }
}
