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
            statusBarText.Text = "ファイルを選択してください";
            imgButtonInit();

        }

        //イメージボタン初期化
        private void imgButtonInit()
        {
            Bitmap ieImg = getImageFromResource("ie32.png");
            Bitmap ffImg = getImageFromResource("ff32.png");
            Bitmap gcImg = getImageFromResource("gc32.png");
            Bitmap cfxImg = getImageFromResource("cfx32.png");
            ieButton.Image = ieImg;
            ffButton.Image = ffImg;
            gcButton.Image = gcImg;
            cfxButton.Image = cfxImg;

        }

        //ファイル選択ダイアログ
        private void getOpenFileName()
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "HTMLファイル(*.html;*.htm)|*.html;*.htm|すべてのファイル(*.*)|*.*";
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
            string html = File.getTextFileText(filename);
            urlArray = HtmlUtil.urlListDatasFromHtml(html);
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

        private void openItem_Click(object sender, EventArgs e)
        {
            getOpenFileName();
            if (!fileMenu.Equals(""))
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
    }
}
