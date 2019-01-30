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

            string se = Console.ReadLine();

            string x = W.GetData(se);



            ParseHTML ll = new ParseHTML(x, "img");

            List<string> dd = ParseHTML.rData;


            


            
            foreach(string zz in dd)
            {
                Util.Download(zz, @"C:\Users\MUA\Downloads\dom", (cou++).ToString(),se);

                Debug.WriteLine(zz);
            }


        }


    }
}
