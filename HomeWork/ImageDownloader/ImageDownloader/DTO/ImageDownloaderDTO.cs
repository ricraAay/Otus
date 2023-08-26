namespace Otus.HomeWork.ImageDownloader
{
    public class DownloaderDTO
    {
        /// <summary>
        /// Токен
        /// </summary>
        public CancellationTokenSource TokeSource { get; set; }

        /// <summary>
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Таск
        /// </summary>
        public Task DownloadTask { get; set; }
    }
}
