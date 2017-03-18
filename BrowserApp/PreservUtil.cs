﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Diagnostics;

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

        //リンク画像を枠で囲う
        public void tag_link_img(Boolean alt_attr)
        {
            HtmlElementCollection ats = d.GetElementsByTagName("a");
            int i = 0;
            foreach(HtmlElement a in ats)
            {
                HtmlElementCollection img = a.GetElementsByTagName("img");
                if(img.Count > 0 && alt_attr)
                {
                    a.Style = "position:relative";
                    add_label(a, i);
                }
                foreach(HtmlElement imgtag in img)
                {
                    imgtag.Style = "border:2px dotted red;";
                    if (alt_attr)
                    {
                        HtmlElement span = d.GetElementById("bkm-a-span-" + i);
                        span.InnerHtml = imgtag.GetAttribute("alt");
                    }
                }
                i++;
            }
        }

        //リストを枠で囲う
        public void tag_list()
        {
            string[] tags = { "ul", "ol", "dl", "dt", "dd" };
            for(int i=0; i<tags.Length; i++)
            {
                string val = tags[i].ToString();
                _tag_list_func(val);
            }

        }
        private void _tag_list_func(string tag)
        {
            HtmlElementCollection ts = d.GetElementsByTagName(tag);
            int i = 0;
            foreach(HtmlElement t in ts)
            {
                t.Style = "border:2px dotted red; position: relative;";
                add_label(t, i);
                if(tag.Equals("dt"))
                {
                    HtmlElement span = d.GetElementById("bkm-dt-span-" + i);
                    string old_css_text = span.Style;
                    string new_css_text = old_css_text.Replace("left: 2px;", "left: 20px;");
                    span.Style = new_css_text;
                }
                else if (tag.Equals("dd"))
                {
                    HtmlElement span = d.GetElementById("bkm-dd-span-" + i);
                    string old_css_text = span.Style;
                    string new_css_text = old_css_text.Replace("left: 2px;", "left: 20px;");
                    span.Style = new_css_text;
                }
                i++;
            }
        }

        //セマンティック要素を枠で囲う
        public void tag_semantic()
        {
            string[] tags = { "strong", "em" };
            for(int i=0; i<tags.Length; i++)
            {
                string val = tags[i].ToString();
                _tag_semantic_func(val);
            }
        }
        private void _tag_semantic_func(string tag)
        {
            HtmlElementCollection ts = d.GetElementsByTagName(tag);
            int i = 0;
            foreach(HtmlElement t in ts)
            {
                t.Style = "border:2px dotted red; position: relative;";
                add_label(t, i);
                i++;
            }
        }

        //見出し要素を枠で囲う
        public void tag_heading()
        {
            string[] tags = { "h1", "h2", "h3", "h4", "h5", "h6" };
            for(int i=0; i<tags.Length; i++)
            {
                string val = tags[i].ToString();
                _tag_semantic_func(val);
            }
        }
        private void _tag_heading_func(string tag)
        {
            HtmlElementCollection ts = d.GetElementsByTagName(tag);
            int i = 0;
            foreach(HtmlElement t in ts)
            {
                t.Style = "border:2px dotted red; position: relative;";
                add_label(t, i);
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
