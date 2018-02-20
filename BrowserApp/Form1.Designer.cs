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
            this.nextUrlItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prevUrlItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadUrlItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextBrowseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prevBrowseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageTopItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageBottomItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageRefreshItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.hrefAttrItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleAttrItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.linkListItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ValidatorErrorReportItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.browserControl = new System.Windows.Forms.WebBrowser();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.urlCombo = new System.Windows.Forms.ComboBox();
            this.urlText = new System.Windows.Forms.TextBox();
            this.bsPrevButton = new System.Windows.Forms.Button();
            this.bsNextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.ieButton = new System.Windows.Forms.Button();
            this.ffButton = new System.Windows.Forms.Button();
            this.gcButton = new System.Windows.Forms.Button();
            this.cfxButton = new System.Windows.Forms.Button();
            this.w3cButton = new System.Windows.Forms.Button();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.urlNumberCopyItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.statusBar.Location = new System.Drawing.Point(0, 499);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1098, 22);
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
            this.editMenu,
            this.viewMenu,
            this.browseMenu,
            this.preservMenu,
            this.reportMenu});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1098, 24);
            this.menuBar.TabIndex = 3;
            this.menuBar.Text = "menuStrip1";
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextUrlItem,
            this.prevUrlItem,
            this.reloadUrlItem,
            this.nextBrowseItem,
            this.prevBrowseItem,
            this.pageTopItem,
            this.pageBottomItem,
            this.pageRefreshItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(58, 20);
            this.viewMenu.Text = "表示(&V)";
            // 
            // nextUrlItem
            // 
            this.nextUrlItem.Name = "nextUrlItem";
            this.nextUrlItem.Size = new System.Drawing.Size(186, 22);
            this.nextUrlItem.Text = "次のURL(&A)";
            this.nextUrlItem.Click += new System.EventHandler(this.nextUrlItem_Click);
            // 
            // prevUrlItem
            // 
            this.prevUrlItem.Name = "prevUrlItem";
            this.prevUrlItem.Size = new System.Drawing.Size(186, 22);
            this.prevUrlItem.Text = "前のURL(&S)";
            this.prevUrlItem.Click += new System.EventHandler(this.prevUrlItem_Click);
            // 
            // reloadUrlItem
            // 
            this.reloadUrlItem.Name = "reloadUrlItem";
            this.reloadUrlItem.Size = new System.Drawing.Size(186, 22);
            this.reloadUrlItem.Text = "更新(&Z)";
            this.reloadUrlItem.Click += new System.EventHandler(this.reloadUrlItem_Click);
            // 
            // nextBrowseItem
            // 
            this.nextBrowseItem.Name = "nextBrowseItem";
            this.nextBrowseItem.Size = new System.Drawing.Size(186, 22);
            this.nextBrowseItem.Text = "進む(&N)";
            this.nextBrowseItem.Click += new System.EventHandler(this.nextBrowseItem_Click);
            // 
            // prevBrowseItem
            // 
            this.prevBrowseItem.Name = "prevBrowseItem";
            this.prevBrowseItem.Size = new System.Drawing.Size(186, 22);
            this.prevBrowseItem.Text = "戻る(&B)";
            this.prevBrowseItem.Click += new System.EventHandler(this.prevBrowseItem_Click);
            // 
            // pageTopItem
            // 
            this.pageTopItem.Name = "pageTopItem";
            this.pageTopItem.Size = new System.Drawing.Size(186, 22);
            this.pageTopItem.Text = "ページ最上部に移動(&F)";
            this.pageTopItem.Click += new System.EventHandler(this.pageTopItem_Click);
            // 
            // pageBottomItem
            // 
            this.pageBottomItem.Name = "pageBottomItem";
            this.pageBottomItem.Size = new System.Drawing.Size(186, 22);
            this.pageBottomItem.Text = "ページ最下部に移動(&V)";
            this.pageBottomItem.Click += new System.EventHandler(this.pageBottomItem_Click);
            // 
            // pageRefreshItem
            // 
            this.pageRefreshItem.Name = "pageRefreshItem";
            this.pageRefreshItem.Size = new System.Drawing.Size(186, 22);
            this.pageRefreshItem.Text = "リフレッシュ(&W)";
            this.pageRefreshItem.Click += new System.EventHandler(this.pageRefreshItem_Click);
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
            this.ieItem.Size = new System.Drawing.Size(187, 22);
            this.ieItem.Text = "IEで開く(&A)";
            this.ieItem.Click += new System.EventHandler(this.ieItem_Click);
            // 
            // firefoxItem
            // 
            this.firefoxItem.Name = "firefoxItem";
            this.firefoxItem.Size = new System.Drawing.Size(187, 22);
            this.firefoxItem.Text = "Firefoxで開く(&S)";
            this.firefoxItem.Click += new System.EventHandler(this.firefoxItem_Click);
            // 
            // chromeItem
            // 
            this.chromeItem.Name = "chromeItem";
            this.chromeItem.Size = new System.Drawing.Size(187, 22);
            this.chromeItem.Text = "Chromeで開く(&D)";
            this.chromeItem.Click += new System.EventHandler(this.chromeItem_Click);
            // 
            // cyberfoxItem
            // 
            this.cyberfoxItem.Name = "cyberfoxItem";
            this.cyberfoxItem.Size = new System.Drawing.Size(187, 22);
            this.cyberfoxItem.Text = "任意のブラウザで開く(&F)";
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
            this.altattrItem,
            this.hrefAttrItem,
            this.titleAttrItem});
            this.preservMenu.Name = "preservMenu";
            this.preservMenu.Size = new System.Drawing.Size(101, 20);
            this.preservMenu.Text = "シュミレーション(&S)";
            // 
            // paragraphItem
            // 
            this.paragraphItem.Name = "paragraphItem";
            this.paragraphItem.Size = new System.Drawing.Size(229, 22);
            this.paragraphItem.Text = "段落を枠で表示(&Z)";
            this.paragraphItem.Click += new System.EventHandler(this.paragraphItem_Click);
            // 
            // linkImageItem
            // 
            this.linkImageItem.Name = "linkImageItem";
            this.linkImageItem.Size = new System.Drawing.Size(229, 22);
            this.linkImageItem.Text = "リンク画像を枠で表示(&X)";
            this.linkImageItem.Click += new System.EventHandler(this.linkImageItem_Click);
            // 
            // listItem
            // 
            this.listItem.Name = "listItem";
            this.listItem.Size = new System.Drawing.Size(229, 22);
            this.listItem.Text = "リスト要素を枠で表示(&C)";
            this.listItem.Click += new System.EventHandler(this.listItem_Click);
            // 
            // semanticItem
            // 
            this.semanticItem.Name = "semanticItem";
            this.semanticItem.Size = new System.Drawing.Size(229, 22);
            this.semanticItem.Text = "セマンティック要素を枠で表示(&V)";
            this.semanticItem.Click += new System.EventHandler(this.semanticItem_Click);
            // 
            // headingItem
            // 
            this.headingItem.Name = "headingItem";
            this.headingItem.Size = new System.Drawing.Size(229, 22);
            this.headingItem.Text = "見出し要素を枠で表示(&A)";
            this.headingItem.Click += new System.EventHandler(this.headingItem_Click);
            // 
            // brItem
            // 
            this.brItem.Name = "brItem";
            this.brItem.Size = new System.Drawing.Size(229, 22);
            this.brItem.Text = "br要素を枠で表示(&S)";
            this.brItem.Click += new System.EventHandler(this.brItem_Click);
            // 
            // labelItem
            // 
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(229, 22);
            this.labelItem.Text = "ラベル要素を枠で表示(&D)";
            this.labelItem.Click += new System.EventHandler(this.labelItem_Click);
            // 
            // tableItem
            // 
            this.tableItem.Name = "tableItem";
            this.tableItem.Size = new System.Drawing.Size(229, 22);
            this.tableItem.Text = "テーブル要素を枠で表示(&F)";
            this.tableItem.Click += new System.EventHandler(this.tableItem_Click);
            // 
            // w3cItem
            // 
            this.w3cItem.Name = "w3cItem";
            this.w3cItem.Size = new System.Drawing.Size(229, 22);
            this.w3cItem.Text = "W3Cバリデートを実行(&Q)";
            this.w3cItem.Click += new System.EventHandler(this.w3cItem_Click);
            // 
            // cssCutItem
            // 
            this.cssCutItem.Name = "cssCutItem";
            this.cssCutItem.Size = new System.Drawing.Size(229, 22);
            this.cssCutItem.Text = "CSSカットを実行(&W)";
            this.cssCutItem.Click += new System.EventHandler(this.cssCutItem_Click);
            // 
            // altattrItem
            // 
            this.altattrItem.Name = "altattrItem";
            this.altattrItem.Size = new System.Drawing.Size(229, 22);
            this.altattrItem.Text = "alt属性値を表示(&E)";
            this.altattrItem.Click += new System.EventHandler(this.altattrItem_Click);
            // 
            // hrefAttrItem
            // 
            this.hrefAttrItem.Name = "hrefAttrItem";
            this.hrefAttrItem.Size = new System.Drawing.Size(229, 22);
            this.hrefAttrItem.Text = "href属性値を表示(&H)";
            this.hrefAttrItem.Click += new System.EventHandler(this.hrefAttrItem_Click);
            // 
            // titleAttrItem
            // 
            this.titleAttrItem.Name = "titleAttrItem";
            this.titleAttrItem.Size = new System.Drawing.Size(229, 22);
            this.titleAttrItem.Text = "title属性値を表示(&T)";
            this.titleAttrItem.Click += new System.EventHandler(this.titleAttrItem_Click);
            // 
            // reportMenu
            // 
            this.reportMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkListItem,
            this.ValidatorErrorReportItem});
            this.reportMenu.Name = "reportMenu";
            this.reportMenu.Size = new System.Drawing.Size(69, 20);
            this.reportMenu.Text = "レポート(&R)";
            // 
            // linkListItem
            // 
            this.linkListItem.Name = "linkListItem";
            this.linkListItem.Size = new System.Drawing.Size(224, 22);
            this.linkListItem.Text = "リンク一覧を表示(&X)";
            this.linkListItem.Click += new System.EventHandler(this.linkListItem_Click);
            // 
            // ValidatorErrorReportItem
            // 
            this.ValidatorErrorReportItem.Name = "ValidatorErrorReportItem";
            this.ValidatorErrorReportItem.Size = new System.Drawing.Size(224, 22);
            this.ValidatorErrorReportItem.Text = "バリデート結果レポートを表示(&V)";
            this.ValidatorErrorReportItem.Click += new System.EventHandler(this.ValidatorErrorReportItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.browserControl);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 475);
            this.panel1.TabIndex = 4;
            // 
            // browserControl
            // 
            this.browserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserControl.Location = new System.Drawing.Point(0, 46);
            this.browserControl.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserControl.Name = "browserControl";
            this.browserControl.Size = new System.Drawing.Size(1098, 429);
            this.browserControl.TabIndex = 13;
            this.browserControl.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.browserControl_Navigated);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.urlCombo);
            this.flowLayoutPanel1.Controls.Add(this.urlText);
            this.flowLayoutPanel1.Controls.Add(this.bsPrevButton);
            this.flowLayoutPanel1.Controls.Add(this.bsNextButton);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1098, 46);
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
            this.urlCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urlCombo_KeyPress);
            // 
            // urlText
            // 
            this.urlText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.urlText.Location = new System.Drawing.Point(92, 13);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(495, 19);
            this.urlText.TabIndex = 2;
            this.urlText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urlText_KeyPress);
            // 
            // bsPrevButton
            // 
            this.bsPrevButton.Location = new System.Drawing.Point(593, 3);
            this.bsPrevButton.Name = "bsPrevButton";
            this.bsPrevButton.Size = new System.Drawing.Size(40, 40);
            this.bsPrevButton.TabIndex = 3;
            this.bsPrevButton.UseVisualStyleBackColor = true;
            this.bsPrevButton.Click += new System.EventHandler(this.bsPrevButton_Click);
            // 
            // bsNextButton
            // 
            this.bsNextButton.Location = new System.Drawing.Point(639, 3);
            this.bsNextButton.Name = "bsNextButton";
            this.bsNextButton.Size = new System.Drawing.Size(40, 40);
            this.bsNextButton.TabIndex = 4;
            this.bsNextButton.UseVisualStyleBackColor = true;
            this.bsNextButton.Click += new System.EventHandler(this.bsNextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.prevButton.Location = new System.Drawing.Point(685, 3);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(40, 40);
            this.prevButton.TabIndex = 5;
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nextButton.Location = new System.Drawing.Point(731, 3);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(40, 40);
            this.nextButton.TabIndex = 6;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.reloadButton.Location = new System.Drawing.Point(777, 3);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(40, 40);
            this.reloadButton.TabIndex = 7;
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // ieButton
            // 
            this.ieButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ieButton.Location = new System.Drawing.Point(823, 3);
            this.ieButton.Name = "ieButton";
            this.ieButton.Size = new System.Drawing.Size(40, 40);
            this.ieButton.TabIndex = 8;
            this.ieButton.UseVisualStyleBackColor = true;
            this.ieButton.Click += new System.EventHandler(this.ieButton_Click);
            // 
            // ffButton
            // 
            this.ffButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ffButton.Location = new System.Drawing.Point(869, 3);
            this.ffButton.Name = "ffButton";
            this.ffButton.Size = new System.Drawing.Size(40, 40);
            this.ffButton.TabIndex = 9;
            this.ffButton.UseVisualStyleBackColor = true;
            this.ffButton.Click += new System.EventHandler(this.ffButton_Click);
            // 
            // gcButton
            // 
            this.gcButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gcButton.Location = new System.Drawing.Point(915, 3);
            this.gcButton.Name = "gcButton";
            this.gcButton.Size = new System.Drawing.Size(40, 40);
            this.gcButton.TabIndex = 10;
            this.gcButton.UseVisualStyleBackColor = true;
            this.gcButton.Click += new System.EventHandler(this.gcButton_Click);
            // 
            // cfxButton
            // 
            this.cfxButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cfxButton.Location = new System.Drawing.Point(961, 3);
            this.cfxButton.Name = "cfxButton";
            this.cfxButton.Size = new System.Drawing.Size(40, 40);
            this.cfxButton.TabIndex = 11;
            this.cfxButton.UseVisualStyleBackColor = true;
            this.cfxButton.Click += new System.EventHandler(this.cfxButton_Click);
            // 
            // w3cButton
            // 
            this.w3cButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.w3cButton.Location = new System.Drawing.Point(1007, 3);
            this.w3cButton.Name = "w3cButton";
            this.w3cButton.Size = new System.Drawing.Size(60, 40);
            this.w3cButton.TabIndex = 12;
            this.w3cButton.UseVisualStyleBackColor = true;
            this.w3cButton.Click += new System.EventHandler(this.w3cButton_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urlNumberCopyItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(57, 20);
            this.editMenu.Text = "編集(&E)";
            // 
            // urlNumberCopyItem
            // 
            this.urlNumberCopyItem.Name = "urlNumberCopyItem";
            this.urlNumberCopyItem.Size = new System.Drawing.Size(168, 22);
            this.urlNumberCopyItem.Text = "URL番号をコピー(&C)";
            this.urlNumberCopyItem.Click += new System.EventHandler(this.urlNumberCopyItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 521);
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
        private System.Windows.Forms.ToolStripMenuItem nextUrlItem;
        private System.Windows.Forms.ToolStripMenuItem prevUrlItem;
        private System.Windows.Forms.ToolStripMenuItem reloadUrlItem;
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
        private System.Windows.Forms.Button bsNextButton;
        private System.Windows.Forms.Button bsPrevButton;
        private System.Windows.Forms.ToolStripMenuItem nextBrowseItem;
        private System.Windows.Forms.ToolStripMenuItem prevBrowseItem;
        private System.Windows.Forms.ToolStripMenuItem hrefAttrItem;
        private System.Windows.Forms.ToolStripMenuItem titleAttrItem;
        private System.Windows.Forms.ToolStripMenuItem pageTopItem;
        private System.Windows.Forms.ToolStripMenuItem pageBottomItem;
        private System.Windows.Forms.ToolStripMenuItem pageRefreshItem;
        private System.Windows.Forms.ToolStripMenuItem reportMenu;
        private System.Windows.Forms.ToolStripMenuItem linkListItem;
        private System.Windows.Forms.ToolStripMenuItem ValidatorErrorReportItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem urlNumberCopyItem;
    }
}

