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

    }
}
