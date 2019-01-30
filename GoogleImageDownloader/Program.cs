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
            string x = W.GetData("hello world");

            Debug.WriteLine("-----------------");

            Debug.WriteLine(x);
            Debug.WriteLine("-----------------");

        }


    }
}
