using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleImageDownloader
{
    public class W
    {

        public static string GoogleURL(string name)
        {
            string[] p = name.Split();
            string x = "";
            foreach (string y in p)
            {
                x += y + "+";
            }
            x = x.Substring(0, x.Length - 1);
            return "https://www.google.com/search?q=" + x + "&source=lnms&tbm=isch&sa=X";
        }

        public static string GetData(string url)
        {

            url = GoogleURL(url);

            string data = "";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                data = readStream.ReadToEnd();

                response.Close();
                readStream.Close();
            }

            return data;
        }


    }
}

