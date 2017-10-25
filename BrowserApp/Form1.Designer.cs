namespace BrowserApp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarText = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prevItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ieItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firefoxItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chromeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyberfoxItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preservMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.paragraphItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkImageItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semanticItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headingItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableItem = new System.Windows.Forms.ToolStripMenuItem();
            this.w3cItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cssCutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altattrItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.browserControl = new System.Windows.Forms.WebBrowser();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.urlCombo = new System.Windows.Forms.ComboBox();
            this.urlText = new System.Windows.Forms.TextBox();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.ieButton = new System.Windows.Forms.Button();
            this.ffButton = new System.Windows.Forms.Button();
            this.gcButton = new System.Windows.Forms.Button();
            this.cfxButton = new System.Windows.Forms.Button();
            this.w3cButton = new System.Windows.Forms.Button();
            this.statusBar.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarText});
            this.statusBar.Location = new System.Drawing.Point(0, 409);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(989, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusBarText
            // 
            this.statusBarText.Name = "statusBarText";
            this.statusBarText.Size = new System.Drawing.Size(0, 17);
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openItem,
            this.settingsItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(67, 20);
            this.fileMenu.Text = "ファイル(&F)";
            // 
            // openItem
            // 
            this.openItem.Name = "openItem";
            this.openItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openItem.Size = new System.Drawing.Size(175, 22);
            this.openItem.Text = "開く(&O)";
            this.openItem.Click += new System.EventHandler(this.openItem_Click);
            // 
            // settingsItem
            // 
            this.settingsItem.Name = "settingsItem";
            this.settingsItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.settingsItem.Size = new System.Drawing.Size(175, 22);
            this.settingsItem.Text = "環境設定(&S)";
            this.settingsItem.Click += new System.EventHandler(this.settingsItem_Click);
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.Control;
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.viewMenu,
            this.browseMenu,
            this.preservMenu});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(989, 24);
            this.menuBar.TabIndex = 3;
            this.menuBar.Text = "menuStrip1";
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextItem,
            this.prevItem,
            this.reloadItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(58, 20);
            this.viewMenu.Text = "表示(&V)";
            // 
            // nextItem
            // 
            this.nextItem.Name = "nextItem";
            this.nextItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nextItem.Size = new System.Drawing.Size(155, 22);
            this.nextItem.Text = "進む(&N)";
            this.nextItem.Click += new System.EventHandler(this.nextItem_Click);
            // 
            // prevItem
            // 
            this.prevItem.Name = "prevItem";
            this.prevItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.prevItem.Size = new System.Drawing.Size(155, 22);
            this.prevItem.Text = "戻る(&P)";
            this.prevItem.Click += new System.EventHandler(this.prevItem_Click);
            // 
            // reloadItem
            // 
            this.reloadItem.Name = "reloadItem";
            this.reloadItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reloadItem.Size = new System.Drawing.Size(155, 22);
            this.reloadItem.Text = "更新(&R)";
            this.reloadItem.Click += new System.EventHandler(this.reloadItem_Click);
            // 
            // browseMenu
            // 
            this.browseMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ieItem,
            this.firefoxItem,
            this.chromeItem,
            this.cyberfoxItem});
            this.browseMenu.Name = "browseMenu";
            this.browseMenu.Size = new System.Drawing.Size(69, 20);
            this.browseMenu.Text = "ブラウズ(&B)";
            // 
            // ieItem
            // 
            this.ieItem.Name = "ieItem";
            this.ieItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.ieItem.Size = new System.Drawing.Size(203, 22);
            this.ieItem.Text = "IEで開く(&1)";
            this.ieItem.Click += new System.EventHandler(this.ieItem_Click);
            // 
            // firefoxItem
            // 
            this.firefoxItem.Name = "firefoxItem";
            this.firefoxItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.firefoxItem.Size = new System.Drawing.Size(203, 22);
            this.firefoxItem.Text = "Firefoxで開く(&2)";
            this.firefoxItem.Click += new System.EventHandler(this.firefoxItem_Click);
            // 
            // chromeItem
            // 
            this.chromeItem.Name = "chromeItem";
            this.chromeItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.chromeItem.Size = new System.Drawing.Size(203, 22);
            this.chromeItem.Text = "Chromeで開く(&3)";
            this.chromeItem.Click += new System.EventHandler(this.chromeItem_Click);
            // 
            // cyberfoxItem
            // 
            this.cyberfoxItem.Name = "cyberfoxItem";
            this.cyberfoxItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.cyberfoxItem.Size = new System.Drawing.Size(203, 22);
            this.cyberfoxItem.Text = "Cyberfoxで開く(&4)";
            this.cyberfoxItem.Click += new System.EventHandler(this.cyberfoxItem_Click);
            // 
            // preservMenu
            // 
            this.preservMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paragraphItem,
            this.linkImageItem,
            this.listItem,
            this.semanticItem,
            this.headingItem,
            this.brItem,
            this.labelItem,
            this.tableItem,
            this.w3cItem,
            this.cssCutItem,
            this.altattrItem});
            this.preservMenu.Name = "preservMenu";
            this.preservMenu.Size = new System.Drawing.Size(101, 20);
            this.preservMenu.Text = "シュミレーション(&S)";
            // 
            // paragraphItem
            // 
            this.paragraphItem.Name = "paragraphItem";
            this.paragraphItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.paragraphItem.Size = new System.Drawing.Size(295, 22);
            this.paragraphItem.Text = "段落を枠で表示(&Z)";
            this.paragraphItem.Click += new System.EventHandler(this.paragraphItem_Click);
            // 
            // linkImageItem
            // 
            this.linkImageItem.Name = "linkImageItem";
            this.linkImageItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.linkImageItem.Size = new System.Drawing.Size(295, 22);
            this.linkImageItem.Text = "リンク画像を枠で表示(&X)";
            this.linkImageItem.Click += new System.EventHandler(this.linkImageItem_Click);
            // 
            // listItem
            // 
            this.listItem.Name = "listItem";
            this.listItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.listItem.Size = new System.Drawing.Size(295, 22);
            this.listItem.Text = "リスト要素を枠で表示(&C)";
            this.listItem.Click += new System.EventHandler(this.listItem_Click);
            // 
            // semanticItem
            // 
            this.semanticItem.Name = "semanticItem";
            this.semanticItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D8)));
            this.semanticItem.Size = new System.Drawing.Size(295, 22);
            this.semanticItem.Text = "セマンティック要素を枠で表示(&V)";
            this.semanticItem.Click += new System.EventHandler(this.semanticItem_Click);
            // 
            // headingItem
            // 
            this.headingItem.Name = "headingItem";
            this.headingItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D9)));
            this.headingItem.Size = new System.Drawing.Size(295, 22);
            this.headingItem.Text = "見出し要素を枠で表示(&A)";
            this.headingItem.Click += new System.EventHandler(this.headingItem_Click);
            // 
            // brItem
            // 
            this.brItem.Name = "brItem";
            this.brItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.brItem.Size = new System.Drawing.Size(295, 22);
            this.brItem.Text = "br要素を枠で表示(&S)";
            this.brItem.Click += new System.EventHandler(this.brItem_Click);
            // 
            // labelItem
            // 
            this.labelItem.Name = "labelItem";
            this.labelItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemcomma)));
            this.labelItem.Size = new System.Drawing.Size(295, 22);
            this.labelItem.Text = "ラベル要素を枠で表示(&D)";
            this.labelItem.Click += new System.EventHandler(this.labelItem_Click);
            // 
            // tableItem
            // 
            this.tableItem.Name = "tableItem";
            this.tableItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemPeriod)));
            this.tableItem.Size = new System.Drawing.Size(295, 22);
            this.tableItem.Text = "テーブル要素を枠で表示(&F)";
            this.tableItem.Click += new System.EventHandler(this.tableItem_Click);
            // 
            // w3cItem
            // 
            this.w3cItem.Name = "w3cItem";
            this.w3cItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.w3cItem.Size = new System.Drawing.Size(295, 22);
            this.w3cItem.Text = "W3Cバリデートを実行(&Q)";
            this.w3cItem.Click += new System.EventHandler(this.w3cItem_Click);
            // 
            // cssCutItem
            // 
            this.cssCutItem.Name = "cssCutItem";
            this.cssCutItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemtilde)));
            this.cssCutItem.Size = new System.Drawing.Size(295, 22);
            this.cssCutItem.Text = "CSSカットを実行(&W)";
            this.cssCutItem.Click += new System.EventHandler(this.cssCutItem_Click);
            // 
            // altattrItem
            // 
            this.altattrItem.Name = "altattrItem";
            this.altattrItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemBackslash)));
            this.altattrItem.Size = new System.Drawing.Size(295, 22);
            this.altattrItem.Text = "alt属性値を表示(&E)";
            this.altattrItem.Click += new System.EventHandler(this.altattrItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.browserControl);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 385);
            this.panel1.TabIndex = 4;
            // 
            // browserControl
            // 
            this.browserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserControl.Location = new System.Drawing.Point(0, 46);
            this.browserControl.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserControl.Name = "browserControl";
            this.browserControl.Size = new System.Drawing.Size(989, 339);
            this.browserControl.TabIndex = 10;
            this.browserControl.WebBrowserShortcutsEnabled = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.urlCombo);
            this.flowLayoutPanel1.Controls.Add(this.urlText);
            this.flowLayoutPanel1.Controls.Add(this.prevButton);
            this.flowLayoutPanel1.Controls.Add(this.nextButton);
            this.flowLayoutPanel1.Controls.Add(this.reloadButton);
            this.flowLayoutPanel1.Controls.Add(this.ieButton);
            this.flowLayoutPanel1.Controls.Add(this.ffButton);
            this.flowLayoutPanel1.Controls.Add(this.gcButton);
            this.flowLayoutPanel1.Controls.Add(this.cfxButton);
            this.flowLayoutPanel1.Controls.Add(this.w3cButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(989, 46);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // urlCombo
            // 
            this.urlCombo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.urlCombo.FormattingEnabled = true;
            this.urlCombo.Location = new System.Drawing.Point(3, 13);
            this.urlCombo.Name = "urlCombo";
            this.urlCombo.Size = new System.Drawing.Size(83, 20);
            this.urlCombo.TabIndex = 1;
            this.urlCombo.SelectedIndexChanged += new System.EventHandler(this.urlCombo_SelectedIndexChanged);
            // 
            // urlText
            // 
            this.urlText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.urlText.Location = new System.Drawing.Point(92, 13);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(495, 19);
            this.urlText.TabIndex = 2;
            // 
            // prevButton
            // 
            this.prevButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.prevButton.Location = new System.Drawing.Point(593, 11);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(38, 23);
            this.prevButton.TabIndex = 3;
            this.prevButton.Text = "戻る";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nextButton.Location = new System.Drawing.Point(637, 11);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(35, 23);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "進む";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.reloadButton.Location = new System.Drawing.Point(678, 11);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(38, 23);
            this.reloadButton.TabIndex = 5;
            this.reloadButton.Text = "更新";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // ieButton
            // 
            this.ieButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ieButton.Location = new System.Drawing.Point(722, 3);
            this.ieButton.Name = "ieButton";
            this.ieButton.Size = new System.Drawing.Size(40, 40);
            this.ieButton.TabIndex = 6;
            this.ieButton.UseVisualStyleBackColor = true;
            this.ieButton.Click += new System.EventHandler(this.ieButton_Click);
            // 
            // ffButton
            // 
            this.ffButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ffButton.Location = new System.Drawing.Point(768, 3);
            this.ffButton.Name = "ffButton";
            this.ffButton.Size = new System.Drawing.Size(40, 40);
            this.ffButton.TabIndex = 7;
            this.ffButton.UseVisualStyleBackColor = true;
            this.ffButton.Click += new System.EventHandler(this.ffButton_Click);
            // 
            // gcButton
            // 
            this.gcButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gcButton.Location = new System.Drawing.Point(814, 3);
            this.gcButton.Name = "gcButton";
            this.gcButton.Size = new System.Drawing.Size(40, 40);
            this.gcButton.TabIndex = 8;
            this.gcButton.UseVisualStyleBackColor = true;
            this.gcButton.Click += new System.EventHandler(this.gcButton_Click);
            // 
            // cfxButton
            // 
            this.cfxButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cfxButton.Location = new System.Drawing.Point(860, 3);
            this.cfxButton.Name = "cfxButton";
            this.cfxButton.Size = new System.Drawing.Size(40, 40);
            this.cfxButton.TabIndex = 9;
            this.cfxButton.UseVisualStyleBackColor = true;
            this.cfxButton.Click += new System.EventHandler(this.cfxButton_Click);
            // 
            // w3cButton
            // 
            this.w3cButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.w3cButton.Location = new System.Drawing.Point(906, 3);
            this.w3cButton.Name = "w3cButton";
            this.w3cButton.Size = new System.Drawing.Size(60, 40);
            this.w3cButton.TabIndex = 10;
            this.w3cButton.UseVisualStyleBackColor = true;
            this.w3cButton.Click += new System.EventHandler(this.w3cButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 431);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.Text = "BrowserApp";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusBarText;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openItem;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox urlCombo;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem nextItem;
        private System.Windows.Forms.ToolStripMenuItem prevItem;
        private System.Windows.Forms.ToolStripMenuItem reloadItem;
        private System.Windows.Forms.Button ieButton;
        private System.Windows.Forms.Button ffButton;
        private System.Windows.Forms.Button gcButton;
        private System.Windows.Forms.Button cfxButton;
        private System.Windows.Forms.ToolStripMenuItem browseMenu;
        private System.Windows.Forms.ToolStripMenuItem ieItem;
        private System.Windows.Forms.ToolStripMenuItem firefoxItem;
        private System.Windows.Forms.ToolStripMenuItem chromeItem;
        private System.Windows.Forms.ToolStripMenuItem cyberfoxItem;
        private System.Windows.Forms.ToolStripMenuItem preservMenu;
        private System.Windows.Forms.ToolStripMenuItem paragraphItem;
        public System.Windows.Forms.WebBrowser browserControl;
        private System.Windows.Forms.ToolStripMenuItem linkImageItem;
        private System.Windows.Forms.ToolStripMenuItem listItem;
        private System.Windows.Forms.ToolStripMenuItem semanticItem;
        private System.Windows.Forms.ToolStripMenuItem headingItem;
        private System.Windows.Forms.ToolStripMenuItem labelItem;
        private System.Windows.Forms.ToolStripMenuItem tableItem;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.ToolStripMenuItem w3cItem;
        private System.Windows.Forms.ToolStripMenuItem cssCutItem;
        private System.Windows.Forms.ToolStripMenuItem altattrItem;
        private System.Windows.Forms.Button w3cButton;
        private System.Windows.Forms.ToolStripMenuItem settingsItem;
        private System.Windows.Forms.ToolStripMenuItem brItem;
    }
}

