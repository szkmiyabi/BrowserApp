using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HtmlAgilityPack;
using System.Collections;

namespace BrowserApp
{
    class HtmlUtil
    {
        //URL番号一覧配列の生成
        public static ArrayList urlListDatasFromHtml(string html)
        {
            ArrayList arr = new ArrayList();
            HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            var trs = doc.DocumentNode.SelectNodes(@"/html/body/div[2]/div[1]/table/tr")
                .Skip(2)
                .Select(item =>
                {
                    var data = item.SelectNodes("td");
                    var pageID = data.ElementAt(0).InnerText;
                    var pageURL = data.ElementAt(1).InnerText;
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
    }
}
