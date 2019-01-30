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

        
        
        static void Main(string[] args)
        {

            W w = new W();
            w.Load("www.google.com");
        }

        
    }
}
