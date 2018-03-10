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
    class ValidatorUtil
    {
        private WebBrowser b;
        private HtmlDocument d;
        private string url;
        private Regex bvpt = new Regex(@"http.*://validator.w3.org/check\?*", RegexOptions.Compiled);
        private Regex nvpt = new Regex(@"http.*://validator.w3.org/nu/\?*", RegexOptions.Compiled);
        private HtmlElement rep_wrapper;
        private string _env;

        //コンストラクタ
        public ValidatorUtil(ref WebBrowser b)
        {
            this.b = b;
            this.d = b.Document;
            this.url = b.Url.ToString();
        }

        //初期化
        public void init()
        {
            if (nvpt.IsMatch(url))
            {
                _env = "nu";
                rep_wrapper = d.GetElementById("results");
            }
            else if (bvpt.IsMatch(url))
            {
                _env = "bs";
                rep_wrapper = d.GetElementById("error_loop");
            }
        }

        //環境変数
        public string env
        {
            get { return _env; }
        }
       
        //class名で要素取得
        private List<HtmlElement> GetElementsByClassName(HtmlElement parentElm, string className)
        {
            List<HtmlElement> res = new List<HtmlElement>();
            HtmlElementCollection alldoc = parentElm.GetElementsByTagName("*");
            foreach(HtmlElement elm in alldoc)
            {
                if(elm.GetAttribute("className").ToString() == className)
                {
                    res.Add(elm);
                }
            }
            return res;
        }

        //Nu Html Checkerのレポートを取得
        public string get_nu_validator_errors()
        {
            string str = "";
            int errcnt = 0;
            Regex linept = new Regex(@"(From line )([0-9]+?)(,)", RegexOptions.Compiled);
            HtmlElement inwrap = rep_wrapper.GetElementsByTagName("ol")[0];
            HtmlElementCollection rows = inwrap.GetElementsByTagName("li");
            foreach(HtmlElement row in rows)
            {
                string atr = row.GetAttribute("className").ToString();
                if(atr.Equals("error"))
                {
                    errcnt++;
                    string emsg = row.GetElementsByTagName("p")[0].GetElementsByTagName("span")[0].InnerText;
                    string eline = GetElementsByClassName(row, "location")[0].GetElementsByTagName("a")[0].InnerText;
                    string elinestr = "";
                    MatchCollection mc = linept.Matches(eline);
                    foreach(Match m in mc)
                    {
                        elinestr = m.Groups[2].Value;
                    }
                    elinestr += "行目";
                    string esrc = GetElementsByClassName(row, "extract")[0].GetElementsByTagName("code")[0].InnerText;
                    str += elinestr + "\r\n" + emsg + "\r\n\r\n" + esrc + "\r\n\r\n\r\n";
                }
            }
            return str;

        }

        //W3C Checkerのレポートを取得
        public string get_bs_validator_errors()
        {
            string str = "";
            int errcnt = 0;
            Regex linept = new Regex(@"(Line )([0-9]+?)(,)", RegexOptions.Compiled);
            HtmlElementCollection rows = rep_wrapper.GetElementsByTagName("li");
            foreach(HtmlElement row in rows)
            {
                string atr = row.GetAttribute("className").ToString();
                if (atr.Equals("msg_err"))
                {
                    errcnt++;
                    string eline = row.GetElementsByTagName("em")[0].InnerText;
                    string elinestr = "";
                    MatchCollection mc = linept.Matches(eline);
                    foreach(Match m in mc)
                    {
                        elinestr = m.Groups[2].Value;
                    }
                    elinestr += "行目";
                    string emsg = GetElementsByClassName(row, "msg")[0].InnerText;
                    string esrc = row.GetElementsByTagName("pre")[0].GetElementsByTagName("code")[0].InnerText;
                    str += elinestr + "\r\n" + emsg + "\r\n\r\n" + esrc + "\r\n\r\n\r\n";
                }
            }
            return str;

        }


    }
}
