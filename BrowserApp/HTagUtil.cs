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
    class HTagUtil
    {
        private WebBrowser b;
        private HtmlDocument d;
        private int h_cnt;

        //コンストラクタ
        public HTagUtil(ref WebBrowser b)
        {
            this.b = b;
            this.d = b.Document;
            this.h_cnt = 0;
        }

        //任意の見出し要素を取得
        private List<string> _get_any_headding(string htag_name)
        {
            List<string> ret = new List<string>();
            HtmlElementCollection any_hs = d.GetElementsByTagName(htag_name);
            if(any_hs.Count < 1)
            {
                ret.Add("<" + htag_name + "> は見つかりませんでした。");
                return ret;
            }
            foreach(HtmlElement any_h in any_hs)
            {
                h_cnt++;
                string h_str = any_h.OuterHtml;
                h_str = MyWebClientUtil.rowClean(h_str);
                ret.Add(h_str);
            }
            return ret;
        }

        //見出し要素レポートを生成
        public string get_headding_report()
        {
            string ret = "";
            string[] tags = { "h1", "h2", "h3", "h4", "h5", "h6" };
            for(int i=0; i<tags.Length; i++)
            {
                string val = tags[i].ToString();
                List<string> data = _get_any_headding(val);
                foreach(string s in data)
                {
                    ret += s + "\r\n";
                }
            }
            return ret;

        }

    }
}
