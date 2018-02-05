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
    class PreservUtil
    {
        private WebBrowser b;
        private HtmlDocument d;

        //コンストラクタ
        public PreservUtil(ref WebBrowser b)
        {
            this.b = b;
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
        public void tag_link_img(Boolean alt_flg)
        {
            HtmlElementCollection ats = d.GetElementsByTagName("a");
            int i = 0;
            foreach(HtmlElement a in ats)
            {
                HtmlElementCollection img = a.GetElementsByTagName("img");
                int j = 0;
                foreach(HtmlElement imgtag in img)
                {
                    imgtag.Style = "border:2px dotted red;";
                    if (alt_flg)
                    {
                        HtmlElement span = d.CreateElement("span");
                        span.Id = "bkm-link-img-span-" + i + "-" + j;
                        string alt_val = imgtag.GetAttribute("alt");
                        string html_str = "alt: " + alt_val;
                        span.InnerHtml = html_str;
                        span.Style = "color:#fff;font-size:12px;padding:1px;background:#BF0000;";
                        imgtag.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeBegin, span);
                    }
                    j++;
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

        //テーブル要素を枠で囲う
        public void tag_table()
        {
            _tag_table_table();
            _tag_table_caption();
            _tag_table_th();
        }
        private void _tag_table_table()
        {
            HtmlElementCollection tbls = d.GetElementsByTagName("table");
            int i = 0;
            foreach(HtmlElement tbl in tbls)
            {
                tbl.Style = "border:2px dotted red; position: relative;";
                add_label(tbl, i);
                i++;
            }
            i = 0;
            foreach(HtmlElement tbl in tbls)
            {
                string smry = tbl.GetAttribute("summary");
                HtmlElement span = d.GetElementById("bkm-table-span-" + i);
                string now_label_text = span.InnerHtml;
                string new_label_text = (smry == null) ? now_label_text : now_label_text + ", summary:" + smry;
                span.InnerHtml = new_label_text;
                string old_css_text = span.Style;
                string new_css_text = old_css_text.Replace("top: 2px;", "top: -20px;");
                span.Style = new_css_text;
                i++;
            }
        }
        private void _tag_table_caption()
        {
            HtmlElementCollection cps = d.GetElementsByTagName("caption");
            int i = 0;
            foreach(HtmlElement cp in cps)
            {
                cp.Style = "border:2px dotted red; position: relative;";
                add_label(cp, i);
                i++;
            }
            i = 0;
            foreach(HtmlElement cp in cps)
            {
                HtmlElement span = d.GetElementById("bkm-caption-span-" + i);
                string old_css_text = span.Style;
                string new_css_text = old_css_text.Replace("top: 2px;", "top: -20px;");
                new_css_text = new_css_text.Replace("left: 2px;", "right: 2px;");
                span.Style = new_css_text;
                i++;
            }
        }
        private void _tag_table_th()
        {
            HtmlElementCollection ths = d.GetElementsByTagName("th");
            int i = 0;
            foreach(HtmlElement th in ths)
            {
                th.Style = "border:2px dotted red; position: relative;";
                add_label(th, i);
                i++;
            }
            i = 0;
            foreach(HtmlElement th in ths)
            {
                string scope = th.GetAttribute("scope");
                HtmlElement span = d.GetElementById("bkm-th-span-" + i);
                string now_label_text = span.InnerHtml;
                string new_label_text = (scope == null) ? now_label_text : now_label_text + ", scope:" + scope;
                span.InnerHtml = new_label_text;
                i++;
            }
        }

        //ラベル要素を枠で表示する
        public void tag_label()
        {
            _tag_label_label();
            _tag_label_input();
            _tag_label_textarea();
            _tag_label_select();
        }
        private string _tag_label_forattr_regx_srch(string tag_html)
        {
            Regex pt = new Regex(@"for=""(.+?)\""");
            MatchCollection mt = pt.Matches(tag_html);
            if (mt.Count > 0)
            {
                Match m = mt[0];
                return m.Groups[1].Value;
            }
            else
            {
                return null;
            }
        }
        private void _tag_label_label()
        {
            HtmlElementCollection lbs = d.GetElementsByTagName("label");
            int i = 0;
            foreach(HtmlElement lb in lbs)
            {
                lb.Style = "border:2px dotted red; position: relative;";
                add_label(lb, i);
                i++;
            }
            i = 0;
            foreach (HtmlElement lb in lbs)
            {
                //string forattr = lb.GetAttribute("for");
                string label_html = lb.OuterHtml;
                string forattr = _tag_label_forattr_regx_srch(label_html);
                HtmlElement span = d.GetElementById("bkm-label-span-" + i);
                string now_css_text = span.Style;
                string new_css_text = now_css_text + "display:block; width: 200px;";
                span.Style = new_css_text;
                string now_label_text = span.InnerHtml;
                string new_label_text = (forattr == null) ? now_label_text : now_label_text + ", for:" + forattr;
                span.InnerHtml = new_label_text;
                i++;
            }
        }
        private void _tag_label_input()
        {
            HtmlElementCollection ips = d.GetElementsByTagName("input");
            int i = 0;
            foreach(HtmlElement ip in ips)
            {
                string typeattr = ip.GetAttribute("type");
                if(typeattr == "text" || typeattr == "radio" || typeattr == "check")
                {
                    ip.Style = "border:2px dotted red; position: relative;";
                }
                i++;
            }
            i = 0;
            foreach(HtmlElement ip in ips)
            {
                string typeattr = ip.GetAttribute("type");
                if(typeattr == "text")
                {
                    string id = ip.Id;
                    string now_label_text = ip.GetAttribute("value");
                    string new_label_text = (id == null) ? now_label_text : now_label_text + "id:" + id;
                    ip.SetAttribute("value", new_label_text);
                }
                else if(typeattr == "radio" || typeattr == "check")
                {
                    string id = ip.Id;
                    string label_text = (id == null) ? "" : "id:" + id;
                    HtmlElement span = d.CreateElement("span");
                    string css_text = "color:#000;font-size:90%;opacity:0.8;border:1px solid red;padding:1px;background:yellow;";
                    span.InnerHtml = label_text;
                    span.Style = css_text;
                    ip.InsertAdjacentElement(HtmlElementInsertionOrientation.AfterEnd, span);
                }
                i++;
            }
        }
        private void _tag_label_textarea()
        {
            HtmlElementCollection tas = d.GetElementsByTagName("textarea");
            int i = 0;
            foreach(HtmlElement ta in tas)
            {
                ta.Style = "border:2px dotted red; position: relative;";
                i++;
            }
            i = 0;
            foreach (HtmlElement ta in tas)
            {
                string id = ta.Id;
                string now_label_text = ta.GetAttribute("value");
                string new_label_text = (id == null) ? now_label_text : now_label_text + "id:" + id;
                ta.SetAttribute("value", new_label_text);
                i++;
            }
        }
        private void _tag_label_select()
        {
            HtmlElementCollection sls = d.GetElementsByTagName("select");
            int i = 0;
            foreach(HtmlElement sl in sls)
            {
                sl.Style = "border:2px dotted red; position: relative;";
                i++;
            }
            i = 0;
            foreach(HtmlElement sl in sls)
            {
                string id = sl.Id;
                string label_text = (id == null) ? "" : "id:" + id;
                HtmlElement span = d.CreateElement("span");
                string css_text = "color:#000;font-size:90%;opacity:0.8;border:1px solid red;padding:1px;background:yellow;";
                span.InnerHtml = label_text;
                span.Style = css_text;
                sl.InsertAdjacentElement(HtmlElementInsertionOrientation.AfterEnd, span);
                i++;
            }
        }

        //br要素を枠で囲う
        public void tag_br()
        {
            HtmlElementCollection brs = d.GetElementsByTagName("br");
            int i = 0;
            foreach (HtmlElement br in brs)
            {
                br.Style = "border:2px dotted red;position: relative;";
                i++;
            }
        }

        //W3Cバリデートを実行
        public void w3c_report(string burl)
        {
            string wurl = "http://validator.w3.org/check?uri=";
            wurl += burl;
            wurl += "&charset=%28detect+automatically%29&doctype=Inline&ss=1&group=1&verbose=1";
            wurl += "&user-agent=W3C_Validator%2F1.3+http%3A%2F%2Fvalidator.w3.org%2Fservices";
            b.Navigate(wurl);
        }

        //CSSカットを実行
        public void css_cut()
        {
            ArrayList delarr = new ArrayList();
            HtmlElementCollection links = d.GetElementsByTagName("link");
            foreach(HtmlElement link in links)
            {
                string href = link.GetAttribute("href");
                if (_is_css_file(href)) delarr.Add(href);
            }
            foreach(string line in delarr)
            {
                _delete_link(line);
            }
            HtmlElementCollection tags = d.GetElementsByTagName("*");
            foreach(HtmlElement tag in tags)
            {
                string style = tag.Style;
                if (style != null || style != "") tag.Style = null;
            }
            HtmlElementCollection styles = d.GetElementsByTagName("style");
            foreach(HtmlElement style in styles)
            {
                style.InnerText = null;
            }
        }
        private Boolean _is_css_file(string href)
        {
            Regex pt = new Regex(@".+\.css");
            Match mt = pt.Match(href);
            if (mt.Success) return true;
            else return false;
            
        }
        private void _delete_link(string href)
        {
            HtmlElementCollection lks = d.GetElementsByTagName("link");
            foreach(HtmlElement lk in lks)
            {
                string val = lk.GetAttribute("href");
                if (val == href) lk.OuterHtml = "";
            }
        }

        //alt属性値と画像名を明示
        public void tag_img_alt_fname(Boolean alt_flg, Boolean fname_flg, Boolean alt_attr_flg)
        {
            HtmlElementCollection img = d.GetElementsByTagName("img");
            int i = 0;
            foreach(HtmlElement imgtag in img)
            {
                imgtag.Style = "border:1px solid red;";
                HtmlElement span = d.CreateElement("span");
                span.Id = "bkm-img-span-" + i;
                string src_val = imgtag.GetAttribute("src");
                string fname = _get_img_fname(src_val);
                string alt_val = imgtag.GetAttribute("alt");
                string html_str = "";
                if (alt_flg)
                {
                    html_str += "alt: " + alt_val;
                }
                if (fname_flg)
                {
                    if (html_str != "")
                    {
                        html_str += ", filename: " + fname;
                    }
                    else
                    {
                        html_str += "filename: " + fname;
                    }
                }
                span.InnerHtml = html_str;
                span.Style = "color:#fff;font-size:12px;padding:1px;background:#BF0000;";
                imgtag.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeBegin, span);

                //alt属性値の有無判定
                if(alt_attr_flg)
                {
                    if (!_alt_attr_check(span.Id))
                    {
                        HtmlElement now_span = d.GetElementById(span.Id);
                        string now_str = now_span.InnerHtml;
                        string new_str = now_str.Replace("alt: ", "alt属性がない");
                        now_span.InnerHtml = new_str;
                    }
                }

                i++;
            }
        }
        private Boolean _alt_attr_check(string tar_id)
        {
            string html = "";
            string tar_text = d.Body.InnerHtml;

            tar_text = _text_clean(tar_text);
            Console.WriteLine(tar_text);
            Regex pt1 = new Regex(@"(<span id=""" + tar_id + @""".+?>)(.+?)(</span>)(<img.+?>)");
            MatchCollection mc = pt1.Matches(tar_text);
            if(mc.Count > 0)
            {
                Match mt = mc[0];
                html = mt.Groups[4].Value;
                Console.WriteLine(html);

            }
            Regex pt2 = new Regex(@"alt="".*""");
            Regex pt3 = new Regex(@"alt=");
            if (pt2.IsMatch(html) && pt3.IsMatch(html)) return true;
            else return false;

        }

        private string _text_clean(string str)
        {
            str = Regex.Replace(str, @"^ +", "", RegexOptions.Multiline);
            str = Regex.Replace(str, @"\t+", "", RegexOptions.Multiline);
            str = Regex.Replace(str, @"(\r\n|\r|\n)", "", RegexOptions.Multiline);
            return str;
        }

        private string _get_img_fname(string str)
        {
            string ret = "";
            Regex pt = new Regex(@"(.+)\/(.+\.)(JPG|jpg|GIF|gif|PNG|png|BMP|bmp)$");
            MatchCollection mc = pt.Matches(str);
            if(mc.Count > 0)
            {
                Match mt = mc[0];
                ret = mt.Groups[2].Value + mt.Groups[3].Value;
            }
            return ret;
        }

        //href属性値を明示
        public void tag_href_attr()
        {
            HtmlElementCollection ats = d.GetElementsByTagName("a");
            int i = 0;
            foreach(HtmlElement a in ats)
            {
                string href_val = a.GetAttribute("href");
                HtmlElement span = d.CreateElement("span");
                span.Id = "bkm-href-attr-span-" + i;
                span.InnerHtml = "[ " + href_val + " ]";
                span.Style = "padding-right:5px;color:#fff;font-size:14px;padding:1px;background:#600060;";
                a.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeBegin, span);
                i++;

            }
        }


        //title属性値を明示
        public void tag_title_attr()
        {
            string[] tags = { "a", "input" };
            for(int i=0; i<tags.Length; i++)
            {
                string val = tags[i].ToString();
                _tag_title_attr_func(val);
            }
        }

        private void _tag_title_attr_func(string tag)
        {
            HtmlElementCollection ts = d.GetElementsByTagName(tag);
            int i = 0;
            foreach(HtmlElement t in ts)
            {
                if(tag.Equals("input"))
                {
                    string tp = t.GetAttribute("type");
                    if(tp.Equals("text") || tp.Equals("checkbox") || tp.Equals("radio"))
                    {
                        string title_val = t.GetAttribute("title");
                        HtmlElement span = d.CreateElement("span");
                        span.Id = "bkm-title-attr-span-" + i;
                        span.InnerHtml = "title: " + title_val;
                        span.Style = "padding-right:5px;color:#fff;font-size:12px;padding:1px;background:#000080";
                        t.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeBegin, span);
                    }
                } else
                {
                    string title_val = t.GetAttribute("title");
                    HtmlElement span = d.CreateElement("span");
                    span.Id = "bkm-title-attr-span-" + i;
                    span.InnerHtml = "title: " + title_val;
                    span.Style = "padding-right:5px;color:#fff;font-size:12px;padding:1px;background:#000080;";
                    t.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeBegin, span);
                }
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
            string css_txt = "color:#000;font-size:12px;opacity:0.8;display:block;border:1px solid red;padding:1px;background:yellow;position:absolute;top:2px;left:2px;";
            span.InnerHtml = "&lt;" + tag_name + "&gt;";
            span.Id = span_id;
            span.Style = css_txt;
            obj.AppendChild(span);
        }

        //ページ最上部ヘスクロール
        public void scroll_top_exec()
        {
            d.Window.ScrollTo(new Point(0, 0));
        }

        //ページ最下部へスクロール
        public void scroll_bottom_exec()
        {
            int val1 = d.Body.ClientRectangle.Height;
            int val2 = d.Body.ScrollRectangle.Height;
            int btm = Math.Max(val1, val2);
            d.Window.ScrollTo(new Point(0, btm));

        }
    }
}