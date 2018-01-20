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
                appSettings.pu_tag_img_alt_attr_flag = (imgAltAttrCheck.Checked) ? "yes" : "no";
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
                if (appSettings.pu_tag_img_alt_attr_flag == "yes") imgAltAttrCheck.Checked = true;
                else imgAltAttrCheck.Checked = false;
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
                appSettings.pu_tag_img_alt_attr_flag = "";
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
                imgAltAttrCheck.Checked = false;
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
            string iepath = "";
            string iepath1 = @"C:\Program Files\Internet Explorer\iexplore.exe";
            string iepath2 = @"C:\Program Files (x86)\Internet Explorer\iexplore.exe";
            if (System.IO.File.Exists(iepath1)) iepath = iepath1;
            else if (System.IO.File.Exists(iepath2)) iepath = iepath2;
            if (iepath == "") MessageBox.Show("取得できません");
            else iePathText.Text = iepath;
        }

        //Firefox起動パスを取得
        private void ffPathDefaultLoad()
        {
            string ffpath = "";
            string ffpath1 = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            string ffpath2 = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            if (System.IO.File.Exists(ffpath1)) ffpath = ffpath1;
            else if (System.IO.File.Exists(ffpath2)) ffpath = ffpath2;
            if (ffpath == "") MessageBox.Show("取得できません");
            else ffPathText.Text = ffpath;
        }

        //Chrome起動パスを取得
        private void gcPathDefaultLoad()
        {
            string gcpath = "";
            string gcpath1 = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
            string gcpath2 = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
            string gcpath3 = getUserHomePath() + @"\Local Settings\Application Data\Google\Chrome\Application\chrome.exe";
            if (System.IO.File.Exists(gcpath1)) gcpath = gcpath1;
            else if (System.IO.File.Exists(gcpath2)) gcpath = gcpath2;
            else if (System.IO.File.Exists(gcpath3)) gcpath = gcpath3;
            if (gcpath == "") MessageBox.Show("取得できません");
            else gcPathText.Text = gcpath;
            
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
