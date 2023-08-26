using Otus.HomeWork.ImageDownloader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageDownloader
{
    public class ImageDownloaderView
    {

        private readonly IDownloaderService _service;

        public ImageDownloaderView(IDownloaderService service)
        {
            _service = service;
        }

        public void Execute(List<Uri> urls)
        {

            urls.ForEach(url => _service.DownloadFileTaskAsync(url, url.ToString().Split('/').Last()));

            Console.WriteLine("\nНажмите клавишу \"A\" для выхода или любую другую клавишу для проверки статуса скачивания\n");

            if (Console.ReadLine() == "A")
            {
                _service.CancelDownload();
            }
            else
            {
                _service.GetDownloadStatus();
            }

            Console.ReadKey();
        }
    }
}
