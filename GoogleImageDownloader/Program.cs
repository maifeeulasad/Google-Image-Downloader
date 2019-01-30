using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleImageDownloader
{
    class Program
    {
        static int cou = 0;
        
        
        static void Main(string[] args)
        {
            cou = 0;

            string loc = @"C:\Users\MUA\Downloads\dom\";

            string x = W.GetData("hello world");

            //Debug.WriteLine(x);

            ParseHTML ll = new ParseHTML(x, "img");

            List<string> dd = ParseHTML.rData;


            using (WebClient client = new WebClient())
            {

                client.DownloadFile(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSkhuJUVjHM9DPgNGwSs3dgsMvq7Oa-m02gav39X3IL6yf_QMR3SB50MzeC"), @"C:\Users\MUA\Downloads\dom\1.png");


            }


            /*
            foreach(string zz in dd)
            {
                using (WebClient client = new WebClient())
                {

                    //client.DownloadFile(new Uri(zz), loc + cou.ToString() + ".png");


                }

                //Debug.WriteLine(zz);
            }
            */

        }


    }
}
