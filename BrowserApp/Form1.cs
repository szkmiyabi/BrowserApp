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
using System.Text.RegularExpressions;

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

            Bitmap prevImg = getImageFromResource("bpreview30.png");
            Bitmap nextImg = getImageFromResource("bnext30.png");

            Bitmap prevBtnImg = getImageFromResource("prevbutton30.png");
            Bitmap nextBtnImg = getImageFromResource("nextbutton30.png");
            Bitmap reloadBtnImg = getImageFromResource("reloadbutton30.png");


            Bitmap ieImg = getImageFromResource("ie32.png");
            Bitmap ffImg = getImageFromResource("ff32.png");
            Bitmap gcImg = getImageFromResource("gc32.png");
            Bitmap cfxImg = getImageFromResource("cfx32.png");
            Bitmap w3cImg = getImageFromResource("w3c32.png");


            bsPrevButton.Image = prevImg;
            bsNextButton.Image = nextImg;

            prevButton.Image = prevBtnImg;
            nextButton.Image = nextBtnImg;
            reloadButton.Image = reloadBtnImg;

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
            try
            {

                if (urlArray != null)
                {
                    urlArray = new ArrayList();
                    urlCombo.Items.Clear();
                }

                string buff = File.getTextFileContent(filename);
                string ext = File.getFileExtension(filename);

                if (ext.Equals(".html") || ext.Equals(".htm"))
                {
                    if (File.isReportPage(buff) && !File.isResultPage(buff))
                    {
                        urlArray = File.urlListDatasFromReportPage(buff);
                    }
                    else if (File.isResultPage(buff) && !File.isReportPage(buff))
                    {
                        urlArray = File.urlListDatasFromResultPage(buff);
                    }
                }
                else if (ext.Equals(".txt") || ext.Equals(".csv") || ext.Equals(".tsv"))
                {
                    urlArray = File.urlListDatasFromTextFile(buff);
                }
                else
                {
                    MessageBox.Show("サポートされないファイルを開こうとしました。処理をキャンセルします！");
                    return;
                }

                endOpen();

            }
            catch (Exception ex)
            {
                MessageBox.Show("処理エラーです。ファイルの内容に問題がないか確認してください！");
            }

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
            if (urlArray == null) return;

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

        //URL欄で指定したURL
        private void doBrowseByUrlText()
        {
            try
            {
                string urlStr = urlText.Text;
                Regex pt = new Regex(@"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?");
                Match mt = pt.Match(urlStr);
                if(mt.Success)
                {
                    browserControl.Navigate(urlStr);
                }
                else
                {
                    return;
                }
                
            }
            catch(Exception ex)
            {
                return;
            }
        }

        //urlコンボに入力したURL
        private void doSearchByUrlCombo()
        {
            string key = urlCombo.Text;
            int saveArrIndex = 0;
            int match_cnt = 0;

            //コンボ入力値で配列検索
            for(int i=0; i<urlArray.Count; i++)
            {
                string[] inrow = (string[])urlArray[i];
                string urlNo = inrow[0].ToString();
                string urlStr = inrow[1].ToString();
                if(urlNo.Equals(key))
                {
                    saveArrIndex = i;
                    match_cnt++;
                    break;
                }
            }

            if (match_cnt < 1) return;

            urlCombo.Items.Clear();

            //コンボボックスの再作成
            for (int i = 0; i < urlArray.Count; i++)
            {
                string[] inrow = (string[])urlArray[i];
                urlCombo.Items.Add(inrow[0].ToString());
            }

            //検索結果のURLを選択
            string[] row = (string[])urlArray[saveArrIndex];
            urlText.Text = row[1].ToString();
            urlCombo.SelectedIndex = saveArrIndex;
            browserControl.Navigate(urlText.Text);

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

        //URL番号をコピー
        private void copyUrlNumberToClipboard()
        {
            try
            {
                if (urlCombo.Items.Count > 0)
                {
                    Clipboard.SetDataObject(urlCombo.Text);
                    MessageBox.Show("URL番号をクリップボードにコピーしました！");
                }
                else
                {
                    MessageBox.Show("URL一覧テキストを開いていません！");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("システムエラーです！");
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
            Boolean fname_flg;
            Boolean alt_attr_flg;
            Boolean flag;
            if (pu_tag_img_fname_flag == "yes") fname_flg = true;
            else fname_flg = false;
            if (pu_tag_img_alt_attr_flag == "yes") alt_attr_flg = true;
            else alt_attr_flg = false;
            pu.tag_img_alt_fname(true, fname_flg, alt_attr_flg);
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

        private void urlText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                doBrowseByUrlText();
            }
        }

        private void browserControl_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            urlText.Text = browserControl.Url.ToString();
        }

        private void urlCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (urlArray == null) return;

            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                doSearchByUrlCombo();
            }
        }

        private void bsPrevButton_Click(object sender, EventArgs e)
        {
            browserControl.GoBack();
        }

        private void browserControl_CanGoBackChanged(object sender, EventArgs e)
        {
            bsPrevButton.Enabled = browserControl.CanGoBack;
            prevBrowseItem.Enabled = browserControl.CanGoBack;
        }

        private void bsNextButton_Click(object sender, EventArgs e)
        {
            browserControl.GoForward();
        }

        private void browserControl_CanGoForwardChanged(object sendar, EventArgs e)
        {
            bsNextButton.Enabled = browserControl.CanGoForward;
            nextBrowseItem.Enabled = browserControl.CanGoForward;
        }

        private void nextUrlItem_Click(object sender, EventArgs e)
        {
            doBrowserNext();
        }

        private void prevUrlItem_Click(object sender, EventArgs e)
        {
            doBrowserPrev();
        }

        private void reloadUrlItem_Click(object sender, EventArgs e)
        {
            doBrowserPrev();
        }

        private void nextBrowseItem_Click(object sender, EventArgs e)
        {
            browserControl.GoForward();
        }

        private void prevBrowseItem_Click(object sender, EventArgs e)
        {
            browserControl.GoBack();
        }

        private void hrefAttrItem_Click(object sender, EventArgs e)
        {
            PreservUtil pu = new PreservUtil(ref browserControl);
            pu.tag_href_attr();
        }

        private void titleAttrItem_Click(object sender, EventArgs e)
        {
            PreservUtil pu = new PreservUtil(ref browserControl);
            pu.tag_title_attr();
        }

        private void pageTopItem_Click(object sender, EventArgs e)
        {
            PreservUtil pu = new PreservUtil(ref browserControl);
            pu.scroll_top_exec();
        }

        private void pageBottomItem_Click(object sender, EventArgs e)
        {
            PreservUtil pu = new PreservUtil(ref browserControl);
            pu.scroll_bottom_exec();
        }

        private void pageRefreshItem_Click(object sender, EventArgs e)
        {
            browserControl.Refresh();
        }

        private void linkListItem_Click(object sender, EventArgs e)
        {
            showLinkListDiag();
        }

        private void ValidatorErrorReportItem_Click(object sender, EventArgs e)
        {
            showValidatorDiag();
        }

        private void urlNumberCopyItem_Click(object sender, EventArgs e)
        {
            copyUrlNumberToClipboard();
        }

        private void docLinkFilenameItem_Click(object sender, EventArgs e)
        {
            PreservUtil pu = new PreservUtil(ref browserControl);
            pu.doclink_filename();
        }
    }
}
