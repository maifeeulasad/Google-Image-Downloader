using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleImageDownloader
{
    class ParseHTML
    {

        public static List<string> rData = new List<string>();


        public ParseHTML(string data,string tag)
        {
            Debug.WriteLine(data.Length);
            rData.Clear();
            List<int> i = AllIndexesOf(data, "<" + tag);

            foreach(int x in i)
            {
                int y = data.Substring(x).IndexOf('>');
                string tem = data.Substring(x, y + 1);

            }

        }

        public static List<int> AllIndexesOf(string str, string value)
        {
            List<int> indexes = new List<int>();
            for (int index = 0; ; index += value.Length)
            {
                index = str.IndexOf(value, index);
                if (index == -1)
                    return indexes;
                indexes.Add(index);
            }
        }


    }
}
