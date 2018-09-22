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
    class JsUtil
    {
        private WebBrowser b;
        private HtmlDocument d;
        private string url;

        //コンストラクタ
        public JsUtil(ref WebBrowser b)
        {
            this.b = b;
            this.d = b.Document;
            this.url = b.Url.ToString();
        }

        //head内のscript要素を取得
        private string get_head_scr_tags()
        {
            string html = "";
            MyWebClientUtil mwcu = new MyWebClientUtil();
            string tar_text = mwcu.getHTML(url);

            tar_text = MyWebClientUtil.textClean(tar_text);

            Regex pt = new Regex(@"(<script.+?>)(.*?)(</script>)", RegexOptions.IgnoreCase);
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

        //body内のscript要素を取得
        private string get_body_scr_tags()
        {
            string html = "";
            HtmlElementCollection sts = d.GetElementsByTagName("script");
            foreach (HtmlElement st in sts)
            {
                string row = st.OuterHtml;
                row = MyWebClientUtil.rowClean(row);
                html += row + "\r\n";
            }
            return html;
        }


        //JSの要素レポートを生成
        public string get_js_tag_report()
        {
            string ret = "";
            ret += "■script要素 (head要素内)\r\n" + get_head_scr_tags() + "\r\n";
            ret += "■script要素 (body要素内)\r\n" + get_body_scr_tags() + "\r\n";
            return ret;
        }
    }
}
