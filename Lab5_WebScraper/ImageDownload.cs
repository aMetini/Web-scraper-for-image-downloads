using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_WebScraper
{
    class ImageDownload
    {
        public Task<byte[]> DownloadTask { get; }

        public Uri URI { get; }

        public ImageDownload(Task<byte[]> downloadTask, Uri uri)
        {
            DownloadTask = downloadTask;
            URI = uri;
        }
    }
}
