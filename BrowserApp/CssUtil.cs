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
    class CssUtil
    {
        private WebBrowser b;
        private HtmlDocument d;
        private string url;

        //コンストラクタ
        public CssUtil(ref WebBrowser b)
        {
            this.b = b;
            this.d = b.Document;
            this.url = b.Url.ToString();
        }

        //link要素を取得
        private string get_link_tags()
        {
            string html = "";
            HtmlElementCollection lnks = d.GetElementsByTagName("link");

            //string tar_text = b.DocumentText;

            MyWebClientUtil mwcu = new MyWebClientUtil();
            string tar_text = mwcu.getHTML(url);
            //System.Diagnostics.Debug.WriteLine(tar_text);

            tar_text = MyWebClientUtil.textClean(tar_text);

            Regex pt = new Regex(@"(<link.+?)( */*>)", RegexOptions.IgnoreCase);
            MatchCollection mc = pt.Matches(tar_text);
            if (mc.Count > 0)
            {
                foreach (Match mt in mc)
                {
                    string vl = mt.Value;
                    html += vl + "\r\n";
                }
            }
            return html;
        }

        //style要素を取得
        private string get_style_tags()
        {
            string html = "";
            HtmlElementCollection sts = d.GetElementsByTagName("style");
            foreach(HtmlElement st in sts)
            {
                string row = st.OuterHtml;
                row = MyWebClientUtil.rowClean(row);
                html += row + "\r\n";
            }
            return html;
        }

        //style属性を取得
        private string get_style_attrs()
        {
            string html = "";
            string tar_text = d.Body.InnerHtml;
            tar_text = MyWebClientUtil.textClean(tar_text);

            Regex pt = new Regex(@"style="".+?""", RegexOptions.IgnoreCase);
            MatchCollection mc = pt.Matches(tar_text);
            if(mc.Count > 0)
            {
                foreach(Match mt in mc)
                {
                    string vl = mt.Value;
                    html += vl + "\r\n";
                }
            }
            return html;
        }

        //CSSの要素レポートを生成
        public string get_css_tag_report()
        {
            string ret = "";
            ret += "■link要素\r\n" + get_link_tags() + "\r\n";
            ret += "■style要素\r\n" + get_style_tags() + "\r\n";
            ret += "■style属性\r\n" + get_style_attrs();
            return ret;
        }

    }
}
