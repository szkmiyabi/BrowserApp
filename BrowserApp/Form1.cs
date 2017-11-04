using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;

namespace BrowserApp
{
    public partial class Form1 : Form
    {
        private string filename;
        private ArrayList urlArray;
        private int arrIndex;

        public Form1()
        {
            InitializeComponent();
            appInit();
        }

        //初期化
        private void appInit()
        {
            //IE11モード有効
            initRegistry();
            //statusbar初期化
            statusBarText.Text = "ファイルを選択してください";
            //イメージボタン初期化
            imgButtonInit();
            //環境設定をロード
            loadAppSettings();

        }

        //イメージボタン初期化
        private void imgButtonInit()
        {
            Bitmap ieImg = getImageFromResource("ie32.png");
            Bitmap ffImg = getImageFromResource("ff32.png");
            Bitmap gcImg = getImageFromResource("gc32.png");
            Bitmap cfxImg = getImageFromResource("cfx32.png");
            Bitmap w3cImg = getImageFromResource("w3c32.png");
            ieButton.Image = ieImg;
            ffButton.Image = ffImg;
            gcButton.Image = gcImg;
            cfxButton.Image = cfxImg;
            w3cButton.Image = w3cImg;

        }

        //ファイル選択ダイアログ
        private void getOpenFileName()
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "すべてのファイル(*.*)|*.*|HTMLファイル(*.html;*.htm)|*.html;*.htm|テキストファイル(*.txt)|*.txt";
            if(f.ShowDialog() == DialogResult.OK)
            {
                filename = f.FileName;
            }
        }

        //ファイルをロード
        private void loadFile()
        {
            if(urlArray != null)
            {
                urlArray = new ArrayList();
                urlCombo.Items.Clear();
            }
            string buff = File.getTextFileContent(filename);
            string ext = File.getFileExtension(filename);

            if(ext.Equals(".html"))
            {
                if(File.isReportPage(buff) && !File.isResultPage(buff))
                {
                    urlArray = File.urlListDatasFromReportPage(buff);
                } else if(File.isResultPage(buff) && !File.isReportPage(buff))
                {
                    urlArray = File.urlListDatasFromResultPage(buff);
                }
            }
            else if(ext.Equals(".txt"))
            {
                urlArray = File.urlListDatasFromTextFile(buff);
            }
            endOpen();
        }

        //ファイルを開いた後の処理
        private void endOpen()
        {
            if(urlArray != null)
            {
                arrIndex = 0;
                statusBarText.Text = filename;
                //コンボボックスの生成
                for(int i=0; i<urlArray.Count; i++)
                {
                    string[] inrow = (string[])urlArray[i];
                    urlCombo.Items.Add(inrow[0].ToString());
                }
                //初期値の設定
                string[] row = (string[])urlArray[0];
                urlText.Text = row[1].ToString();
                urlCombo.SelectedIndex = 0;
                browserControl.Navigate(urlText.Text);
            }
        }

        //更新
        private void doReload()
        {
            string[] row = (string[])urlArray[arrIndex];
            string urlNo = row[0].ToString();
            string urlStr = row[1].ToString();
            urlText.Text = urlStr;
            browserControl.Navigate(urlStr);
        }

        //前のURL
        private void doBrowserPrev()
        {
            if (urlArray != null)
            {
                if (arrIndex == 0)
                {
                    return;
                }
                arrIndex--;
                string[] row = (string[])urlArray[arrIndex];
                string urlNo = row[0].ToString();
                string urlStr = row[1].ToString();
                urlText.Text = urlStr;
                urlCombo.SelectedIndex = arrIndex;
                browserControl.Navigate(urlStr);
            }
        }

        //次のURL
        private void doBrowserNext()
        {
            if(urlArray != null)
            {
                if(arrIndex == (urlArray.Count - 1))
                {
                    return;
                }
                arrIndex++;
                string[] row = (string[])urlArray[arrIndex];
                string urlNo = row[0].ToString();
                string urlStr = row[1].ToString();
                urlText.Text = urlStr;
                urlCombo.SelectedIndex = arrIndex;
                browserControl.Navigate(urlStr);
            }
        }

        //comboで指定したURL
        private void doBrowseByCombo()
        {
            try
            {
                string keyVal = "";
                keyVal = urlCombo.SelectedItem.ToString();
                int pos = urlCombo.SelectedIndex;
                if(urlArray != null)
                {
                    string[] row = (string[])urlArray[pos];
                    string urlNo = row[0].ToString();
                    string urlStr = row[1].ToString();
                    urlText.Text = urlStr;
                    browserControl.Navigate(urlStr);
                    arrIndex = pos;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        //IEでURLを開く
        private void browseByIE()
        {
            try
            {
                string burl = urlText.Text;
                System.Diagnostics.Process.Start(iePath, " " + burl);
            }
            catch(Exception ex)
            {
            }
        }

        //FirefoxでURLを開く
        private void browseByFirefox()
        {
            try
            {
                string burl = urlText.Text;
                System.Diagnostics.Process.Start(ffPath, "-new-tab " + burl);
            }
            catch (Exception ex)
            {
            }
        }

        //CyberfoxでURLを開く
        private void browseByCyberfox()
        {
            try
            {
                string burl = urlText.Text;
                System.Diagnostics.Process.Start(etcBrowserPath, "-new-tab " + burl);
            }
            catch (Exception ex)
            {
            }
        }

        //ChromeでURLを開く
        private void browseByChrome()
        {
            try
            {
                string burl = urlText.Text;
                System.Diagnostics.Process.Start(gcPath, " " + burl);
            }
            catch(Exception ex)
            {
            }
        }

        private void openItem_Click(object sender, EventArgs e)
        {
            getOpenFileName();
            if (filename != null)
            {
                loadFile();
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            doBrowserPrev();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            doBrowserNext();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            doReload();
        }

        private void urlCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            doBrowseByCombo();
        }

        private void nextItem_Click(object sender, EventArgs e)
        {
            doBrowserNext();
        }

        private void prevItem_Click(object sender, EventArgs e)
        {
            doBrowserPrev();
        }

        private void reloadItem_Click(object sender, EventArgs e)
        {
            doReload();
        }

        private void ieButton_Click(object sender, EventArgs e)
        {
            browseByIE();
        }

        private void ffButton_Click(object sender, EventArgs e)
        {
            browseByFirefox();
        }

        private void cfxButton_Click(object sender, EventArgs e)
        {
            browseByCyberfox();
        }

        private void gcButton_Click(object sender, EventArgs e)
        {
            browseByChrome();
        }

        private void ieItem_Click(object sender, EventArgs e)
        {
            browseByIE();
        }

        private void firefoxItem_Click(object sender, EventArgs e)
        {
            browseByFirefox();
        }

        private void chromeItem_Click(object sender, EventArgs e)
        {
            browseByChrome();
        }

        private void cyberfoxItem_Click(object sender, EventArgs e)
        {
            browseByCyberfox();
        }

        private void paragraphItem_Click(object sender, EventArgs e)
        {
            PreservUtil pu = new PreservUtil(ref browserControl);
            pu.tag_paragraph();
        }

        private void listItem_Click(object sender, EventArgs e)
        {
            PreservUtil pu = new PreservUtil(ref browserControl);
            pu.tag_list();
        }

        private void linkImageItem_Click(object sender, EventArgs e)
        {
            PreservUtil pu = new PreservUtil(ref browserControl);
            Boolean flag;
            if (pu_tag_link_img_alt_flag == "yes") flag = true;
            else flag = false;
            pu.tag_link_img(flag);
        }

        private void semanticItem_Click(object sender, EventArgs e)
        {
            PreservUtil pu = new PreservUtil(ref browserControl);
            pu.tag_semantic();
        }

        private void headingItem_Click(object sender, EventArgs e)
        {
            PreservUtil pu = new PreservUtil(ref browserControl);
            pu.tag_heading();
        }

        private void tableItem_Click(object sender, EventArgs e)
        {
            PreservUtil pu = new PreservUtil(ref browserControl);
            pu.tag_table();
        }

        private void labelItem_Click(object sender, EventArgs e)
        {
            PreservUtil pu = new PreservUtil(ref browserControl);
            pu.tag_label();
        }

        private void w3cItem_Click(object sender, EventArgs e)
        {
            string burl = urlText.Text;
            PreservUtil pu = new PreservUtil(ref browserControl);
            pu.w3c_report(burl);
        }

        private void cssCutItem_Click(object sender, EventArgs e)
        {
            PreservUtil pu = new PreservUtil(ref browserControl);
            pu.css_cut();
        }

        private void altattrItem_Click(object sender, EventArgs e)
        {
            PreservUtil pu = new PreservUtil(ref browserControl);
            Boolean flag;
            if (pu_tag_img_fname_flag == "yes") flag = true;
            else flag = false;
            pu.tag_img_alt_fname(true, flag);
        }

        private void w3cButton_Click(object sender, EventArgs e)
        {
            string burl = urlText.Text;
            PreservUtil pu = new PreservUtil(ref browserControl);
            pu.w3c_report(burl);
        }

        private void settingsItem_Click(object sender, EventArgs e)
        {
            showSettingDiag();
        }

        private void brItem_Click(object sender, EventArgs e)
        {
            PreservUtil pu = new PreservUtil(ref browserControl);
            pu.tag_br();
        }
    }
}
