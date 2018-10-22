using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Reflection;
using System.Drawing;

using System.Xml.Serialization;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BrowserApp
{
    partial class Form1
    {
        Microsoft.Win32.RegistryKey regkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(FEATURE_BROWSER_EMULATION);
        const string FEATURE_BROWSER_EMULATION = @"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION";
        string process_name = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";
        string process_dbg_name = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".vshost.exe";

        private Settings appSettings;
        private static string settings_filename = "settings.config";

        private string iePath;
        private string ffPath;
        private string gcPath;
        private string etcBrowserPath;
        private string pu_tag_link_img_alt_flag;
        private string pu_tag_img_fname_flag;
        private string pu_tag_img_alt_attr_flag;

        private static ReportBaseForm _rpBaseFrm;


        //webBrowserコントロールをIE11で稼働させる設定
        private void initRegistry()
        {
            regkey.SetValue(process_name, 11001, Microsoft.Win32.RegistryValueKind.DWord);
            regkey.SetValue(process_dbg_name, 11001, Microsoft.Win32.RegistryValueKind.DWord);
        }

        //imageリソースを取得
        private Bitmap getImageFromResource(string imgname)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream("BrowserApp.resources." + imgname);
            Bitmap bmp = new Bitmap(stream);
            return bmp;
        }


        //ReportBaseFormのインスタンスの取得
        public static ReportBaseForm rpBaseFrm
        {
            get
            {
                if (_rpBaseFrm == null || _rpBaseFrm.IsDisposed)
                {
                    _rpBaseFrm = new ReportBaseForm();
                }
                return _rpBaseFrm;
            }
        }

        //アプリ設定データを取得
        private void loadAppSettings()
        {
            try
            {
                appSettings = new Settings();
                XmlSerializer xsz = new XmlSerializer(typeof(Settings));
                StreamReader sr = new StreamReader(
                    settings_filename,
                    new System.Text.UTF8Encoding(false)
                );
                appSettings = (Settings)xsz.Deserialize(sr);
                sr.Close();

                iePath = appSettings.iePath;
                ffPath = appSettings.ffPath;
                gcPath = appSettings.gcPath;
                etcBrowserPath = appSettings.etcBrowserPath;
                pu_tag_link_img_alt_flag = appSettings.pu_tag_link_img_alt_flag;
                pu_tag_img_fname_flag = appSettings.pu_tag_img_fname_flag;
                pu_tag_img_alt_attr_flag = appSettings.pu_tag_img_alt_attr_flag;

                //Debug.WriteLine(iePath);
                //Debug.WriteLine(ffPath);
                //Debug.WriteLine(gcPath);
                //Debug.WriteLine(etcBrowserPath);

            }
            catch(Exception ex)
            {

            }

        }

        //設定ダイアログを表示
        private void showSettingDiag()
        {
            SettingDialog sd = new SettingDialog();
            sd.ShowDialog(this);
            sd.Dispose();
            //設定を再読込
            loadAppSettings();
        }

        //url文字列正規表現判定
        private Boolean is_valid_url(string str)
        {
            Regex pt = new Regex(@"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?");
            if (pt.IsMatch(str)) return true;
            else return false;

        }

        //コマンドライン引数からURLを受け取った場合の処理
        private void withUrlParameterAct(string url_param)
        {
            if(is_valid_url(url_param))
            {
                urlText.Text = url_param;
                browserControl.Navigate(url_param);
            }
        }

        //リンクリストダイアログを表示
        private void showLinkListDiag()
        {

            LinkUtil lu = new LinkUtil(ref browserControl);
            try
            {
                //リンクリストを取得
                string res = lu.get_link_list();
                int cnt = lu.linkCnt;
                rpBaseFrm.reportBaseFormText.Text = res;
                rpBaseFrm.reportBaseStatusBarLabel.Text = "";
                rpBaseFrm.reportBaseStatusBarLabel.Text = cnt.ToString() + "件のリンクが見つかりました。";
                rpBaseFrm.ShowDialog(this);
                //rpBaseFrm.Dispose();

            }
            catch(Exception ex)
            {
                MessageBox.Show("ページを表示していません！");
            }

        }

        //バリデート結果レポートダイアログを表示
        private void showValidatorDiag()
        {
            ValidatorUtil vu = new ValidatorUtil(ref browserControl);
            string res = "";

            try
            {
                vu.init();
                if (vu.env.Equals("nu")) res = vu.get_nu_validator_errors();
                else if (vu.env.Equals("bs")) res = vu.get_bs_validator_errors();
                rpBaseFrm.reportBaseFormText.Text = "";
                rpBaseFrm.reportBaseFormText.Text = res;
                rpBaseFrm.ShowDialog(this);
            }
            catch(Exception ex)
            {
                MessageBox.Show("html validatorの結果ページを表示していません！");

            }

        }

        //CSS要素レポートダイアログを表示
        private void showCssDiag()
        {
            CssUtil cu = new CssUtil(ref browserControl);
            string res = "";

            try
            {
                res = cu.get_css_tag_report();
                rpBaseFrm.reportBaseFormText.Text = "";
                rpBaseFrm.reportBaseFormText.Text = res;
                rpBaseFrm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("レポートを表示できません！");

            }

        }


        //JS要素レポートダイアログを表示
        private void showJsDiag()
        {
            JsUtil ju = new JsUtil(ref browserControl);
            string res = "";

            try
            {
                res = ju.get_js_tag_report();
                rpBaseFrm.reportBaseFormText.Text = "";
                rpBaseFrm.reportBaseFormText.Text = res;
                rpBaseFrm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("レポートを表示できません！");

            }

        }


        //見出し要素レポートダイアログを表示
        private void showHTagDiag()
        {
            HTagUtil htu = new HTagUtil(ref browserControl);
            string res = "";

            try
            {
                res = htu.get_headding_report();
                rpBaseFrm.reportBaseFormText.Text = "";
                rpBaseFrm.reportBaseFormText.Text = res;
                rpBaseFrm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("レポートを表示できません！");

            }

        }

        //DOCTYPEを確認する
        private void showDocType()
        {
            MyWebClientUtil mwcu = new MyWebClientUtil();
            string url = urlText.Text;
            if (url.Equals("")) return;

            string html = mwcu.getHTML(url);
            html = MyWebClientUtil.textClean(html);
            //System.Diagnostics.Debug.WriteLine(html);
            string dtd = MyWebClientUtil.getDocType(html);
            MessageBox.Show(dtd);
        }

        //URLをダイレクト参照しているか判定
        private Boolean isDirectBrowse(string urlTextVal)
        {
            Boolean ret_flg = true;

            if (urlArray != null && urlCombo.Items.Count > 0)
            {
                if (_exist_url_in_array(urlTextVal)) ret_flg = false;
            }
            return ret_flg;

        }
        private Boolean _exist_url_in_array(string str)
        {
            Boolean match_flg = false;
            for (int i = 0; i < urlArray.Count; i++)
            {
                string[] row = (string[])urlArray[i];
                string urlStr = row[1].ToString();
                if (urlStr.Equals(str)) match_flg = true;
            }
            return match_flg;
        }

    }
}
