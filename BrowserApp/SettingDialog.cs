using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml.Serialization;
using System.IO;

namespace BrowserApp
{
    public partial class SettingDialog : Form
    {

        private Settings appSettings;
        private static string filename = "settings.config";

        //コンストラクタ
        public SettingDialog()
        {
            InitializeComponent();
            appSettings = new Settings();
            loadSettings();
        }

        //環境設定を保存する
        private void saveSettings()
        {
            try
            {
                appSettings.iePath = iePathText.Text;
                appSettings.ffPath = ffPathText.Text;
                appSettings.gcPath = gcPathText.Text;
                appSettings.etcBrowserPath = etcBrowserText.Text;
                appSettings.pu_tag_link_img_alt_flag = (linkImgAltCheck.Checked) ? "yes" : "no";
                appSettings.pu_tag_img_fname_flag = (imgFnameCheck.Checked) ? "yes" : "no";
                XmlSerializer xsz = new XmlSerializer(typeof(Settings));
                StreamWriter sw = new StreamWriter(
                    filename,
                    false,
                    new System.Text.UTF8Encoding(false)
                );
                xsz.Serialize(sw, appSettings);
                sw.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("設定が保存でませんでした。" + ex.Message);
            }

        }

        //環境設定をロードする
        private void loadSettings()
        {
            try
            {
                XmlSerializer xsz = new XmlSerializer(typeof(Settings));
                StreamReader sr = new StreamReader(
                    filename,
                    new System.Text.UTF8Encoding(false)
                );
                appSettings = (Settings)xsz.Deserialize(sr);
                sr.Close();

                iePathText.Text = appSettings.iePath;
                ffPathText.Text = appSettings.ffPath;
                gcPathText.Text = appSettings.gcPath;
                etcBrowserText.Text = appSettings.etcBrowserPath;
                if (appSettings.pu_tag_link_img_alt_flag == "yes") linkImgAltCheck.Checked = true;
                else linkImgAltCheck.Checked = false;
                if (appSettings.pu_tag_img_fname_flag == "yes") imgFnameCheck.Checked = true;
                else imgFnameCheck.Checked = false;
            }
            catch(Exception ex)
            {
            }
        }

        //環境設定を削除する
        private void deleteSettings()
        {
            try
            {
                appSettings.iePath = "";
                appSettings.ffPath = "";
                appSettings.gcPath = "";
                appSettings.etcBrowserPath = "";
                appSettings.pu_tag_link_img_alt_flag = "";
                appSettings.pu_tag_img_fname_flag = "";
                XmlSerializer xsz = new XmlSerializer(typeof(Settings));
                StreamWriter sw = new StreamWriter(
                    filename,
                    false,
                    new System.Text.UTF8Encoding(false)
                );
                xsz.Serialize(sw, appSettings);
                sw.Close();

                iePathText.Text = "";
                ffPathText.Text = "";
                gcPathText.Text = "";
                etcBrowserText.Text = "";
                linkImgAltCheck.Checked = false;
                imgFnameCheck.Checked = false;
                MessageBox.Show("設定が削除できました。");
            }
            catch(Exception ex)
            {
                MessageBox.Show("設定が削除できませんでした。" + ex.Message);
            }
        }

        //IE起動パスを取得
        private void iePathDefaultLoad()
        {
            string iepath = @"C:\Program Files\Internet Explorer\iexplore.exe";
            iePathText.Text = iepath;
        }

        //Firefox起動パスを取得
        private void ffPathDefaultLoad()
        {
            string ffpath = "";
            if (getOSBitType().Equals("32"))
            {
                ffpath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            }
            else if (getOSBitType().Equals("64"))
            {
                ffpath = @"C:\Program Files(x86)\Mozilla Firefox\firefox.exe";
            }
            ffPathText.Text = ffpath;
        }

        //Chrome起動パスを取得
        private void gcPathDefaultLoad()
        {
            string gc_default_path = "";
            string gcpath = "";
            string appPath = "";
            if (getOSBitType().Equals("32"))
            {
                gc_default_path = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
            }
            else if (getOSBitType().Equals("64"))
            {
                gc_default_path = @"C:\Program Files(x86)\Google\Chrome\Application\chrome.exe";
            }

            if (System.IO.File.Exists(gc_default_path))
            {
                gcpath = gc_default_path;
                gcPathText.Text = gcpath;
            }
            else
            {
                string usrPath = getUserHomePath();
                if (getOSVersion().Equals("upper-xp"))
                {
                    gcpath = @"AppData\Local\Google\Chrome\Application\chrome.exe";
                }
                else if (getOSVersion().Equals("under-xp"))
                {
                    gcpath = @"Local Settings\Application Data\Google\Chrome\Application\chrome.exe";
                }
                appPath = usrPath + @"\" + gcpath;
                gcPathText.Text = appPath;
            }

        }

        //他のブラウザ起動パスを取得
        private void etcBrowserPathDefaultLoad()
        {
            string cfxpath = "";
            if (getOSBitType().Equals("32"))
            {
                cfxpath = @"C:\Program Files\Cyberfox\Cyberfox.exe";
            }
            else if (getOSBitType().Equals("64"))
            {
                cfxpath = @"C:\Program Files(x86)\Cyberfox\Cyberfox.exe";
            }
            etcBrowserText.Text = cfxpath;
        }


        //OSビット数判定
        private string getOSBitType()
        {
            if (Environment.Is64BitOperatingSystem) return "64";
            else return "32";
        }

        //OSバージョン判定
        private string getOSVersion()
        {
            System.OperatingSystem os = System.Environment.OSVersion;
            string flag = "";
            if (os.Platform == PlatformID.Win32NT)
            {
                if (os.Version.Major < 6)
                {
                    flag = "under-xp";
                }
                else
                {
                    flag = "upper-xp";
                }
            }
            return flag;
        }

        //ユーザのホームフォルダパス
        private string getUserHomePath()
        {
            return System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        }

        private void ieDefaultBtn_Click(object sender, EventArgs e)
        {
            iePathDefaultLoad();
        }

        private void ffDefaultBtn_Click(object sender, EventArgs e)
        {
            ffPathDefaultLoad();
        }

        private void gcDefaultBtn_Click(object sender, EventArgs e)
        {
            gcPathDefaultLoad();
        }

        private void settingSaveButton_Click(object sender, EventArgs e)
        {
            saveSettings();
        }

        private void diagOKButton_Click(object sender, EventArgs e)
        {
            saveSettings();
        }

        private void deleteSettingBtn_Click(object sender, EventArgs e)
        {
            deleteSettings();
        }
    }
}
