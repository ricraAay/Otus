using System.Text;

namespace Otus.HomeWork.FileDirectory
{
    public class FileDirectory
    {
        private readonly DirectoryInfo _directoryInfo;

        public FileDirectory(string path)
        {
            _directoryInfo = new DirectoryInfo(path);
        }

        public void CreateDirectory()
        {
            if (!_directoryInfo.Exists)
            {
                _directoryInfo.Create();
            }

            string[] logValue = new string[]
            {
                $"Название каталога: {_directoryInfo.Name}",
                $"Полное название каталога: {_directoryInfo.FullName}",
                $"Время создания каталога: {_directoryInfo.CreationTime}\n"
            };

            Console.WriteLine(string.Join('\n', logValue));
        }

        public void CreateSubdirectory(string path)
        {
            var dir = _directoryInfo.CreateSubdirectory(path);

            string[] logValue = new string[]
            {
                $"Название подкаталога: {dir.Name}",
                $"Полное название каталога: {dir.FullName}",
                $"Время создания каталога: {dir.CreationTime}\n"
            };

            Console.WriteLine(string.Join('\n', logValue));
        }

        public void CreateFile(string path, string[] text)
        {
            try
            {
                File.WriteAllLines(path, text, Encoding.UTF8);

                Console.WriteLine("Файл: {0}", path);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        public string ReadAllText(string path)
        {
            return File.ReadAllText(Path.Combine(path));
        }
    }
}
