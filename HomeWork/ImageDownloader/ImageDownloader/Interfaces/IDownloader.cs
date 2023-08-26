using System.Net;

namespace Otus.HomeWork.ImageDownloader
{
    public interface IDownloader
    {
        /// <summary>
        /// Метод загрузки файлов
        /// </summary>
        /// <param name="requestUri">Ссылка на файл</param>
        /// <param name="name">Наименование файла</param>
        /// <returns>Таск</returns>
        public Task DownloadFileTaskAsync(CancellationTokenSource tokenSource, Uri requestUri, string name);
    }
}
