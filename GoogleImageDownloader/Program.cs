using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GoogleImageDownloader
{
    class Program
    {
        static string GoogleURL(string name)
        {
            string[] p = name.Split();
            string x = "";
            foreach(string y in p)
            {
                x += y + "+";
            }
            x = x.Substring(0, x.Length - 1);
            return "https://www.google.com/search?q="+x+"&source=lnms&tbm=isch&sa=X";
        }

        static int cou=0;
        static void Main(string[] args)
        {
            string name = "hello world";
            string basicLoc = @"F:\c_sharp\google_image_downloader\New folder\";
            /*
             * https://www.google.com/search?q=hello+world&source=lnms&tbm=isch&sa=X
             */

            string remoteFileUrl = GoogleURL(name);
            string localFileName = basicLoc + (++cou).ToString() + ".jpg";
       

           

            WebClient webClient = new WebClient();
            webClient.DownloadFile(remoteFileUrl, localFileName);

        }
    }
}
