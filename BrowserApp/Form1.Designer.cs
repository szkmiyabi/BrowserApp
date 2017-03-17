﻿namespace BrowserApp
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
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarText = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.browserControl = new System.Windows.Forms.WebBrowser();
            this.urlCombo = new System.Windows.Forms.ComboBox();
            this.urlText = new System.Windows.Forms.TextBox();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prevItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ieButton = new System.Windows.Forms.Button();
            this.ffButton = new System.Windows.Forms.Button();
            this.gcButton = new System.Windows.Forms.Button();
            this.cfxButton = new System.Windows.Forms.Button();
            this.statusBar.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarText});
            this.statusBar.Location = new System.Drawing.Point(0, 409);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(964, 22);
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
            this.openItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(85, 22);
            this.fileMenu.Text = "ファイル(&F)";
            // 
            // openItem
            // 
            this.openItem.Name = "openItem";
            this.openItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openItem.Size = new System.Drawing.Size(152, 22);
            this.openItem.Text = "開く";
            this.openItem.Click += new System.EventHandler(this.openItem_Click);
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.Control;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.viewMenu});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(964, 26);
            this.menuBar.TabIndex = 3;
            this.menuBar.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.browserControl);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 383);
            this.panel1.TabIndex = 4;
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
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(964, 46);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // browserControl
            // 
            this.browserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserControl.Location = new System.Drawing.Point(0, 46);
            this.browserControl.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserControl.Name = "browserControl";
            this.browserControl.Size = new System.Drawing.Size(964, 337);
            this.browserControl.TabIndex = 1;
            this.browserControl.WebBrowserShortcutsEnabled = false;
            // 
            // urlCombo
            // 
            this.urlCombo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.urlCombo.FormattingEnabled = true;
            this.urlCombo.Location = new System.Drawing.Point(3, 13);
            this.urlCombo.Name = "urlCombo";
            this.urlCombo.Size = new System.Drawing.Size(83, 20);
            this.urlCombo.TabIndex = 0;
            this.urlCombo.SelectedIndexChanged += new System.EventHandler(this.urlCombo_SelectedIndexChanged);
            // 
            // urlText
            // 
            this.urlText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.urlText.Location = new System.Drawing.Point(92, 13);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(495, 19);
            this.urlText.TabIndex = 1;
            // 
            // prevButton
            // 
            this.prevButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.prevButton.Location = new System.Drawing.Point(593, 11);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(38, 23);
            this.prevButton.TabIndex = 2;
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
            this.nextButton.TabIndex = 3;
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
            this.reloadButton.TabIndex = 4;
            this.reloadButton.Text = "更新";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextItem,
            this.prevItem,
            this.reloadItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(62, 22);
            this.viewMenu.Text = "表示(&V)";
            // 
            // nextItem
            // 
            this.nextItem.Name = "nextItem";
            this.nextItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nextItem.Size = new System.Drawing.Size(152, 22);
            this.nextItem.Text = "進む";
            this.nextItem.Click += new System.EventHandler(this.nextItem_Click);
            // 
            // prevItem
            // 
            this.prevItem.Name = "prevItem";
            this.prevItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.prevItem.Size = new System.Drawing.Size(152, 22);
            this.prevItem.Text = "戻る";
            this.prevItem.Click += new System.EventHandler(this.prevItem_Click);
            // 
            // reloadItem
            // 
            this.reloadItem.Name = "reloadItem";
            this.reloadItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reloadItem.Size = new System.Drawing.Size(152, 22);
            this.reloadItem.Text = "更新";
            this.reloadItem.Click += new System.EventHandler(this.reloadItem_Click);
            // 
            // ieButton
            // 
            this.ieButton.Location = new System.Drawing.Point(722, 3);
            this.ieButton.Name = "ieButton";
            this.ieButton.Size = new System.Drawing.Size(40, 40);
            this.ieButton.TabIndex = 5;
            this.ieButton.UseVisualStyleBackColor = true;
            this.ieButton.Click += new System.EventHandler(this.ieButton_Click);
            // 
            // ffButton
            // 
            this.ffButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ffButton.Location = new System.Drawing.Point(768, 3);
            this.ffButton.Name = "ffButton";
            this.ffButton.Size = new System.Drawing.Size(40, 40);
            this.ffButton.TabIndex = 6;
            this.ffButton.UseVisualStyleBackColor = true;
            this.ffButton.Click += new System.EventHandler(this.ffButton_Click);
            // 
            // gcButton
            // 
            this.gcButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gcButton.Location = new System.Drawing.Point(814, 3);
            this.gcButton.Name = "gcButton";
            this.gcButton.Size = new System.Drawing.Size(40, 40);
            this.gcButton.TabIndex = 7;
            this.gcButton.UseVisualStyleBackColor = true;
            this.gcButton.Click += new System.EventHandler(this.gcButton_Click);
            // 
            // cfxButton
            // 
            this.cfxButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cfxButton.Location = new System.Drawing.Point(860, 3);
            this.cfxButton.Name = "cfxButton";
            this.cfxButton.Size = new System.Drawing.Size(40, 40);
            this.cfxButton.TabIndex = 8;
            this.cfxButton.UseVisualStyleBackColor = true;
            this.cfxButton.Click += new System.EventHandler(this.cfxButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 431);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
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
        private System.Windows.Forms.WebBrowser browserControl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox urlCombo;
        private System.Windows.Forms.TextBox urlText;
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
    }
}

