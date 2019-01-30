using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GoogleImageDownloader
{
    class Util
    {

        public static void Download(string url,string location,string serial,string se)
        {

            Directory.CreateDirectory(location + "\\" + se);

            using (WebClient client = new WebClient())
            {
                try
                {
                    client.DownloadFile(new Uri(url), location + "\\"+se + "\\" + serial + ".png");

                }
                catch(Exception e)
                {
                    Debug.WriteLine(e);
                }



            }
        }


    }
}
