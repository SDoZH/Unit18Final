using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit18Final
{
    public class GetAsync : Command
    {
            YoutubeDownloader downloader;

            public GetAsync(YoutubeDownloader downloader)
            {
                this.downloader = downloader;
            }

            public override async Task Run()
            {
                await downloader.GetInfo();
            }
    }
}
