using ImageDownloader;
using System.Net;
using System.Threading.Tasks;

namespace Otus.HomeWork.ImageDownloader
{
    public class Program
    {
        async static Task Main(string[] args)
        {
            var imageDownloaderView = new ImageDownloaderView(new ImageDownloaderService(new ImageDownloader()));

            imageDownloaderView.Execute(new List<Uri> {
                new Uri("https://i.pinimg.com/originals/3c/f2/f3/3cf2f33bc94ddab069eeed864995ce7d.jpg"),
                new Uri("https://w.forfun.com/fetch/b2/b255d4d9b4ded6a0773bde74f51b5211.jpeg"),
                new Uri("https://gocsgo.net/wp-content/uploads/2022/08/010.jpg"),
                new Uri("https://moewalls.com/wp-content/uploads/2021/12/ship-crash-mass-effect-andromeda-thumb.jpg"),
                new Uri("https://images.hdqwalls.com/download/fire-in-the-sky-4k-ns-1440x900.jpg"),
                new Uri("https://macnoob.ru/wp-content/uploads/2020/06/night.jpg"),
                new Uri("https://phonoteka.top/uploads/posts/2021-06/1624381942_7-phonoteka_org-p-chernaya-dira-oboi-krasivo-7.jpg"),
                new Uri("https://images.wallpaperscraft.ru/image/single/gorod_vid_sverhu_doroga_156925_3840x2160.jpg"),
                new Uri("https://w.forfun.com/fetch/69/69552484cde1afe153189b3f812b8e8f.jpeg"),
                new Uri("https://w.forfun.com/fetch/72/722c09769536c7610aa6b42379470c4c.jpeg"),
            });
        }
    }
}