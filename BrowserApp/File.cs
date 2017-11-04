using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Collections;
using System.Text.RegularExpressions;

using AngleSharp;
using AngleSharp.Parser.Html;



namespace BrowserApp
{
    class File
    {
        //テキストファイルをロード
        public static string getTextFileContent(string filepath)
        {
            string body = "";
            if(filepath != null)
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

        //ファイル拡張子を判別する
        public static string getFileExtension(string filepath)
        {
            string pt = @".+(\..+)";
            Regex rgx = new Regex(pt, RegexOptions.IgnoreCase);
            Match mt = rgx.Match(filepath);
            if (mt.Success) return mt.Groups[1].Value;
            else return "";
        }

        //検査結果ページかどうか判定
        public static Boolean isResultPage(string html)
        {
            var psr = new HtmlParser();
            var d = psr.Parse(html);
            string tt = d.Title;
            if (tt.Equals("確認用検査結果")) return true;
            else return false;
        }

        //検査証明書ページかどうか判定
        public static Boolean isReportPage(string html)
        {
            var parser = new HtmlParser();
            var doc = parser.Parse(html);
            string tt = doc.Title;
            if (!tt.Equals("確認用検査結果")) return true;
            else return false;
        }

        //確認用検査結果ページからURL配列を生成
        public static ArrayList urlListDatasFromResultPage(string html)
        {
            ArrayList arr = new ArrayList();
            var parser = new HtmlParser();
            var doc = parser.Parse(html);
            var trs = doc.QuerySelectorAll("#report > div.contents.clearfix.list > div.list > table > tbody > tr")
                .Skip(2)
                .Select(item =>
                {
                    var data = item.GetElementsByTagName("td");
                    var pageID = data.ElementAt(0).TextContent.Trim();
                    var pageURL = data.ElementAt(1).TextContent.Trim();
                    return new { pageID = pageID, pageURL = pageURL };
                }
            );
            trs.ToList().ForEach(tr =>
            {
                string[] row = new string[2];
                row[0] = tr.pageID;
                row[1] = tr.pageURL;
                arr.Add(row);
            });

            return arr;
        }

        //検査証ページからURL配列を生成
        public static ArrayList urlListDatasFromReportPage(string html)
        {
            ArrayList arr = new ArrayList();
            var parser = new HtmlParser();
            var doc = parser.Parse(html);
            var trs = doc.QuerySelectorAll("#report > div > div > div.contents.clearfix.result > table.summary > tbody > tr")
                .Skip(2)
                .Select(item =>
                {
                    var data = item.GetElementsByTagName("td");
                    var pageID = data.ElementAt(1).TextContent.Trim();
                    var pageURL = data.ElementAt(2).TextContent.Trim();
                    return new { pageID = pageID, pageURL = pageURL };
                }
            );
            trs.ToList().ForEach(tr =>
            {
                string[] row = new string[2];
                row[0] = tr.pageID;
                row[1] = tr.pageURL;
                arr.Add(row);
            });

            return arr;
        }

        //タブ区切りテキストからURL配列を生成
        public static ArrayList urlListDatasFromTextFile(string text)
        {
            ArrayList arr = new ArrayList();
            char[] delimiter = { '\t', ',' };
            StringReader sr = new StringReader(text);
            while(sr.Peek() > -1)
            {
                string line = sr.ReadLine();
                string[] tmp = line.Split(delimiter);
                string[] row = new string[2];
                row[0] = tmp[0];
                row[1] = tmp[1];
                arr.Add(row);
            }

            return arr;
        }
    }
}
