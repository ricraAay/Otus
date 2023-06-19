namespace Otus.HomeWork.Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var quadcopter = new Quadcopter();

                foreach (var component in quadcopter.GetComponents())
                {
                    Console.WriteLine(component);
                }

                quadcopter.Charge();

                quadcopter.GetInfo();

            } catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}