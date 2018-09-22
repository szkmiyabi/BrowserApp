using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserApp
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string url_param = "";
            if (args.Length > 0) url_param = args[0];
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (url_param.Equals("")) Application.Run(new Form1());
            else Application.Run(new Form1(url_param));
        }
    }
}
