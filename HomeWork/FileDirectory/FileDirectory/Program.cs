using System.IO;
using System.Runtime;
using System.Text;
using System.Xml.Linq;

namespace Otus.HomeWork.FileDirectory
{
    public class Program
    {
        static void Main(string[] args)
        {
            var mainPath = @"C:\Otus";
            var path = Path.Combine(mainPath);

            var fileDirectory = new FileDirectory(path);

            Console.WriteLine("\n# Создание католога:\n");

            fileDirectory.CreateDirectory();

            Console.WriteLine("\n# Создание подкатологов:\n");

            fileDirectory.CreateSubdirectory("Test1");
            fileDirectory.CreateSubdirectory("Test2");

            Console.WriteLine("\n# Создание файлов:\n");

            for (int i = 1; i <= 10; i++)
            {
                var name = $"File{i}.txt";

                fileDirectory.CreateFile(Path.Combine(path, "Test1", name), new[] { name });
                fileDirectory.CreateFile(Path.Combine(path, "Test2", name), new[] { name });
            }

            Console.WriteLine("\n# Добавление данных в файл:\n");

            for (int i = 1; i <= 10; i++)
            {
                var name = $"File{i}.txt";
                var dt = DateTime.Now.ToString();

                var textFromTestFirst = fileDirectory.ReadAllText(Path.Combine(path, "Test1", name));
                var textFromTestSecond = fileDirectory.ReadAllText(Path.Combine(path, "Test2", name));

                fileDirectory.CreateFile(Path.Combine(path, "Test1", name), new[] { textFromTestFirst, dt });
                fileDirectory.CreateFile(Path.Combine(path, "Test2", name), new[] { textFromTestSecond, dt });
            }

            Console.WriteLine("\nЧтенеие файла:\n");

            for (int i = 1; i <= 10; i++)
            {
                var name = $"File{i}.txt";
                var dt = DateTime.Now.ToString();

                var textFromTestFirst = fileDirectory.ReadAllText(Path.Combine(path, "Test1", name));
                var textFromTestSecond = fileDirectory.ReadAllText(Path.Combine(path, "Test2", name));

                Console.WriteLine($"{Path.Combine(path, "Test1", name)}:\n{textFromTestFirst}");
                Console.WriteLine($"{Path.Combine(path, "Test2", name)}:\n{textFromTestSecond}");
            }
        }
    }
}