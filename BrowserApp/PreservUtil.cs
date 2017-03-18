using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace BrowserApp
{
    class PreservUtil
    {
        private HtmlDocument d;

        //コンストラクタ
        public PreservUtil(ref WebBrowser b)
        {
            this.d = b.Document;
        }

        //段落を枠で囲う
        public void tag_paragraph()
        {
            HtmlElementCollection ps = d.GetElementsByTagName("p");
            int i = 0;
            foreach(HtmlElement p in ps)
            {
                p.Style = "border:2px dotted red; position: relative;";
                add_label(p, i);
                i++;
            }

        }

        //要素名ラベルを表示
        private void add_label(HtmlElement obj, int cnt)
        {
            HtmlElement span = d.CreateElement("span");
            string tag_name = obj.TagName;
            tag_name = tag_name.ToLower();
            string span_id = "bkm-" + tag_name + "-span-" + cnt;
            string css_txt = "color:#000;font-size:90%;opacity:0.8;display:block;border:1px solid red;padding:1px;background:yellow;position:absolute;top:2px;left:2px;";
            span.InnerHtml = "&lt;" + tag_name + "&gt;";
            span.Id = span_id;
            span.Style = css_txt;
            obj.AppendChild(span);
        }

    }
}
