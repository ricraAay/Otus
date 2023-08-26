namespace Otus.HomeWork.ImageDownloader
{
    public interface IDownloaderService
    {
        /// <summary>
        /// Загрузка файла
        /// </summary>
        /// <param name="requestUri">Ссылка на изображение</param>
        /// <param name="name">Наименование файла</param>
        /// <returns>Task</returns>
        void DownloadFileTaskAsync(Uri requestUri, string name);

        /// <summary>
        /// Получение статуса
        /// </summary>
        void GetDownloadStatus();

        /// <summary>
        /// Прерывание операции скачивания
        /// </summary>
        void CancelDownload();
    }
}
