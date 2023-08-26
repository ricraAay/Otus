namespace Otus.HomeWork.ImageDownloader
{
    public class ImageDownloaderService : IDownloaderService
    {
        private readonly IDownloader _downloader;

        private readonly List<DownloaderDTO> _tasks;

        public ImageDownloaderService(IDownloader downloader)
        {
            _downloader = downloader;
            _tasks = new List<DownloaderDTO>();
        }

        public void DownloadFileTaskAsync(Uri requestUri, string name)
        {
            var tokenSource = new CancellationTokenSource();

            _tasks.Add(new DownloaderDTO
            {
                TokeSource = tokenSource,
                Name = name,
                DownloadTask = _downloader.DownloadFileTaskAsync(tokenSource, requestUri, name)
            });
        }

        public void GetDownloadStatus()
        {
            Console.WriteLine("Статус загрузки файлов: ");

            _tasks.ForEach(task => Console.WriteLine($"<{task.Name}> - {task.DownloadTask.IsCompleted}"));

            Console.WriteLine();
        }

        public void CancelDownload()
        {
            Console.WriteLine("Прерывание операции скачивания: ");

            _tasks.ToList().ForEach(task => task.TokeSource.Cancel());

            Console.WriteLine();
        }
    }
}
