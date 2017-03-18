using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace BrowserApp
{
    class JavascriptUtil
    {
        public static void js_test(ref WebBrowser browserControl)
        {
            browserControl.Url = new Uri("javascript:(function(){alert('test');})();");
        }
    }
}
