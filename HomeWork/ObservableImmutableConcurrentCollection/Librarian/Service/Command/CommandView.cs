namespace Otus.HomeWork.Librarian
{
    public class CommandView : ICommandOperation
    {
        private readonly Librrary _librrary;

        public CommandView(Librrary librrary)
        {
            _librrary = librrary;
        }

        public void Execute() 
        {
            Console.WriteLine(" - ваши книги:\n");

            foreach(var item in _librrary.Books)
            {
                Console.WriteLine($"{item.Key} - {item.Value}%");
            }
        }
    }
}
