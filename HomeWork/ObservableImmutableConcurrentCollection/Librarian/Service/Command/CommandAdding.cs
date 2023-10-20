namespace Otus.HomeWork.Librarian
{
    public class CommandAdding : ICommandOperation
    {
        private readonly Librrary _librrary;

        public CommandAdding(Librrary librrary) 
        {
            _librrary = librrary;
        }

        public void Execute() 
        {
            Console.Write(" - Введите название книги: ");

            var name = Console.ReadLine();

            if (string.IsNullOrEmpty(name)) {
                Execute();
            }

            _librrary.Add(name);
        }
    }
}
