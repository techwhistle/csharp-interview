using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Downloader
    {
        public event EventHandler DownloadCompleted;

        public void StartDownload()
        {
            Console.WriteLine("Downloading...");

            // Simulate work with delay
            System.Threading.Thread.Sleep(1000);

            DownloadCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
