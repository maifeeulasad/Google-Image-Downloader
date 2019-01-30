using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleImageDownloader
{
    public class W
    {
        WebBrowser web;

        public W()
        {
            Init();
        }
        public W(string url)
        {
            Init();
            Load(url);

        }

        void Init()
        {
            var t = new Thread(I);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

        }

        void I()
        {
            web = new WebBrowser();
            web.DocumentCompleted += Web_DocumentCompleted;
        }

        private void Web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Show();
            //throw new NotImplementedException();
        }

        public void Load(string url)
        {
            web.Navigate(url);

            for(int i=0;i<100000;i++)
            {

            }
        }




        void Show()
        {
            var c = web.Document.Images;
            foreach (var x in c)
            {
                Debug.WriteLine(x);
            }
        }
        

    }
}

