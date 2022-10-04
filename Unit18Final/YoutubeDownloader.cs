using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;


namespace Unit18Final
{
    public class YoutubeDownloader
    {
        YoutubeClient youtubeClient;
        string videoUrl;

        public YoutubeDownloader(string videoUrl)
        {
            youtubeClient = new YoutubeClient();
            this.videoUrl = videoUrl;
        }

        public async Task GetInfo()
        {
            var videoInfo = await youtubeClient.Videos.GetAsync(videoUrl);

            Console.WriteLine($"Название видео: {videoInfo.Title}");
            Console.WriteLine($"Дата : {videoInfo.UploadDate}");
            Console.WriteLine($"Продолжительность: {videoInfo.Duration}");
            Console.WriteLine($"Канал: {videoInfo.Author}");
            Console.WriteLine();
        }
        public async Task Download()
        {
            Console.WriteLine("Введите название для скачиваемого видео:");
            string title = Console.ReadLine() + ".mp4";
            //Скачивание
            await youtubeClient.Videos.DownloadAsync(videoUrl, title, builder => builder.SetPreset(ConversionPreset.UltraFast));
            Console.WriteLine("Скачивание прошло успешно");
        }
    }
}
