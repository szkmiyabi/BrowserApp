using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace BrowserApp
{
    class File
    {
        //HTMLファイルをロード
        public static string getTextFileText(string filepath)
        {
            string body = "";
            if(!filepath.Equals(""))
            {
                StreamReader sr = new StreamReader(
                    filepath,
                    System.Text.Encoding.GetEncoding("UTF-8")
                );
                body = sr.ReadToEnd();
                sr.Close();
            }

            return body;
        }
    }
}
