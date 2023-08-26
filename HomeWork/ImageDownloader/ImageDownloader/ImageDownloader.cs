using System.Net;

namespace Otus.HomeWork.ImageDownloader
{
    public class ImageDownloader : IDownloader
    {
        public ImageDownloader() { }

        public delegate void DownloaderStateHandler(string message);

        public event DownloaderStateHandler ImageStarted = (string message)
            => Console.WriteLine(message);

        public event DownloaderStateHandler ImageCompleted = (string message)
            => Console.WriteLine(message);

        public event DownloaderStateHandler ImageCancel = (string message)
            => Console.WriteLine(message);

        public async Task DownloadFileTaskAsync(CancellationTokenSource tokenSource, Uri requestUri, string name)
        {
            using (var client = new WebClient())
            {
                ImageStarted?.Invoke($"{name} - начало загрузки файла");

                await Task.Delay(1500);

                if (tokenSource.Token.IsCancellationRequested)
                {
                    ImageCancel?.Invoke($"{name} - операция прервана");
                    return;
                }

                await Task.Run(async () => await client.DownloadFileTaskAsync(requestUri, @"c:/temp/" + name), tokenSource.Token);

                ImageCompleted?.Invoke($"{name} - файл загружен");
            }
        }
    }
}
