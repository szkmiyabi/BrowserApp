using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Collections;
using System.Drawing;


namespace BrowserApp
{
    class LinkUtil
    {
        private WebBrowser b;
        private HtmlDocument d;
        private int _linkCnt;

        //コンストラクタ
        public LinkUtil(ref WebBrowser b)
        {
            this.b = b;
            this.d = b.Document;
            this._linkCnt = 0;
        }

        //リンク数のgetter
        public int linkCnt
        {
            get { return _linkCnt; }
        }

        //リンクリストを取得
        public string get_link_list()
        {
            HtmlElementCollection ats = d.GetElementsByTagName("a");
            int i = 0;

            string str = "";
            Regex pt = new Regex(@"^http.*://.+", RegexOptions.Compiled);

            foreach (HtmlElement a in ats)
            {
                string href_val = a.GetAttribute("href");
                if(pt.IsMatch(href_val))
                {
                    str += href_val + "\r\n";
                    _linkCnt++;
                }
            }
            return str;
        }
    }
}
