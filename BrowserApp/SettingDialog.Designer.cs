namespace BrowserApp
{
    partial class SettingDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.diagOKButton = new System.Windows.Forms.Button();
            this.diagCancelButton = new System.Windows.Forms.Button();
            this.deleteSettingBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.iePathLabel = new System.Windows.Forms.Label();
            this.iePathText = new System.Windows.Forms.TextBox();
            this.ieDefaultBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.ffPathLabel = new System.Windows.Forms.Label();
            this.ffPathText = new System.Windows.Forms.TextBox();
            this.ffDefaultBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.gcPathLabel = new System.Windows.Forms.Label();
            this.gcPathText = new System.Windows.Forms.TextBox();
            this.gcDefaultBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.etcBrowserPathLabel = new System.Windows.Forms.Label();
            this.etcBrowserText = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkImgLabel = new System.Windows.Forms.Label();
            this.linkImgAltCheck = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.imgAltFnameLabel = new System.Windows.Forms.Label();
            this.imgFnameCheck = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 263);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 42);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.diagOKButton);
            this.flowLayoutPanel1.Controls.Add(this.diagCancelButton);
            this.flowLayoutPanel1.Controls.Add(this.deleteSettingBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(437, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(329, 42);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // diagOKButton
            // 
            this.diagOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.diagOKButton.Location = new System.Drawing.Point(4, 4);
            this.diagOKButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diagOKButton.Name = "diagOKButton";
            this.diagOKButton.Size = new System.Drawing.Size(100, 29);
            this.diagOKButton.TabIndex = 0;
            this.diagOKButton.Text = "OK";
            this.diagOKButton.UseVisualStyleBackColor = true;
            this.diagOKButton.Click += new System.EventHandler(this.diagOKButton_Click);
            // 
            // diagCancelButton
            // 
            this.diagCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.diagCancelButton.Location = new System.Drawing.Point(112, 4);
            this.diagCancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diagCancelButton.Name = "diagCancelButton";
            this.diagCancelButton.Size = new System.Drawing.Size(100, 29);
            this.diagCancelButton.TabIndex = 1;
            this.diagCancelButton.Text = "キャンセル";
            this.diagCancelButton.UseVisualStyleBackColor = true;
            // 
            // deleteSettingBtn
            // 
            this.deleteSettingBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteSettingBtn.Location = new System.Drawing.Point(220, 4);
            this.deleteSettingBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteSettingBtn.Name = "deleteSettingBtn";
            this.deleteSettingBtn.Size = new System.Drawing.Size(100, 29);
            this.deleteSettingBtn.TabIndex = 2;
            this.deleteSettingBtn.Text = "設定消去";
            this.deleteSettingBtn.UseVisualStyleBackColor = true;
            this.deleteSettingBtn.Click += new System.EventHandler(this.deleteSettingBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 263);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel7, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(766, 263);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.iePathLabel);
            this.flowLayoutPanel2.Controls.Add(this.iePathText);
            this.flowLayoutPanel2.Controls.Add(this.ieDefaultBtn);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(758, 32);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // iePathLabel
            // 
            this.iePathLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iePathLabel.Location = new System.Drawing.Point(4, 11);
            this.iePathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iePathLabel.Name = "iePathLabel";
            this.iePathLabel.Size = new System.Drawing.Size(144, 15);
            this.iePathLabel.TabIndex = 0;
            this.iePathLabel.Text = "IE実行パス";
            // 
            // iePathText
            // 
            this.iePathText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iePathText.Location = new System.Drawing.Point(156, 7);
            this.iePathText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iePathText.Name = "iePathText";
            this.iePathText.Size = new System.Drawing.Size(464, 22);
            this.iePathText.TabIndex = 1;
            // 
            // ieDefaultBtn
            // 
            this.ieDefaultBtn.Location = new System.Drawing.Point(628, 4);
            this.ieDefaultBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ieDefaultBtn.Name = "ieDefaultBtn";
            this.ieDefaultBtn.Size = new System.Drawing.Size(81, 29);
            this.ieDefaultBtn.TabIndex = 2;
            this.ieDefaultBtn.Text = "自動取得";
            this.ieDefaultBtn.UseVisualStyleBackColor = true;
            this.ieDefaultBtn.Click += new System.EventHandler(this.ieDefaultBtn_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.ffPathLabel);
            this.flowLayoutPanel3.Controls.Add(this.ffPathText);
            this.flowLayoutPanel3.Controls.Add(this.ffDefaultBtn);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(4, 44);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(758, 32);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // ffPathLabel
            // 
            this.ffPathLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ffPathLabel.Location = new System.Drawing.Point(4, 11);
            this.ffPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ffPathLabel.Name = "ffPathLabel";
            this.ffPathLabel.Size = new System.Drawing.Size(144, 15);
            this.ffPathLabel.TabIndex = 0;
            this.ffPathLabel.Text = "Firefox実行パス";
            // 
            // ffPathText
            // 
            this.ffPathText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ffPathText.Location = new System.Drawing.Point(156, 7);
            this.ffPathText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ffPathText.Name = "ffPathText";
            this.ffPathText.Size = new System.Drawing.Size(464, 22);
            this.ffPathText.TabIndex = 1;
            // 
            // ffDefaultBtn
            // 
            this.ffDefaultBtn.Location = new System.Drawing.Point(628, 4);
            this.ffDefaultBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ffDefaultBtn.Name = "ffDefaultBtn";
            this.ffDefaultBtn.Size = new System.Drawing.Size(81, 29);
            this.ffDefaultBtn.TabIndex = 2;
            this.ffDefaultBtn.Text = "自動取得";
            this.ffDefaultBtn.UseVisualStyleBackColor = true;
            this.ffDefaultBtn.Click += new System.EventHandler(this.ffDefaultBtn_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.gcPathLabel);
            this.flowLayoutPanel4.Controls.Add(this.gcPathText);
            this.flowLayoutPanel4.Controls.Add(this.gcDefaultBtn);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(4, 84);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(758, 32);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // gcPathLabel
            // 
            this.gcPathLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gcPathLabel.Location = new System.Drawing.Point(4, 11);
            this.gcPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gcPathLabel.Name = "gcPathLabel";
            this.gcPathLabel.Size = new System.Drawing.Size(144, 15);
            this.gcPathLabel.TabIndex = 0;
            this.gcPathLabel.Text = "Chrome実行パス";
            // 
            // gcPathText
            // 
            this.gcPathText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gcPathText.Location = new System.Drawing.Point(156, 7);
            this.gcPathText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcPathText.Name = "gcPathText";
            this.gcPathText.Size = new System.Drawing.Size(464, 22);
            this.gcPathText.TabIndex = 1;
            // 
            // gcDefaultBtn
            // 
            this.gcDefaultBtn.Location = new System.Drawing.Point(628, 4);
            this.gcDefaultBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcDefaultBtn.Name = "gcDefaultBtn";
            this.gcDefaultBtn.Size = new System.Drawing.Size(81, 29);
            this.gcDefaultBtn.TabIndex = 2;
            this.gcDefaultBtn.Text = "自動取得";
            this.gcDefaultBtn.UseVisualStyleBackColor = true;
            this.gcDefaultBtn.Click += new System.EventHandler(this.gcDefaultBtn_Click);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.etcBrowserPathLabel);
            this.flowLayoutPanel5.Controls.Add(this.etcBrowserText);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(4, 124);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(758, 32);
            this.flowLayoutPanel5.TabIndex = 3;
            // 
            // etcBrowserPathLabel
            // 
            this.etcBrowserPathLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.etcBrowserPathLabel.Location = new System.Drawing.Point(4, 7);
            this.etcBrowserPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.etcBrowserPathLabel.Name = "etcBrowserPathLabel";
            this.etcBrowserPathLabel.Size = new System.Drawing.Size(144, 15);
            this.etcBrowserPathLabel.TabIndex = 0;
            this.etcBrowserPathLabel.Text = "任意ブラウザ実行パス";
            // 
            // etcBrowserText
            // 
            this.etcBrowserText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.etcBrowserText.Location = new System.Drawing.Point(156, 4);
            this.etcBrowserText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.etcBrowserText.Name = "etcBrowserText";
            this.etcBrowserText.Size = new System.Drawing.Size(464, 22);
            this.etcBrowserText.TabIndex = 1;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.linkImgLabel);
            this.flowLayoutPanel6.Controls.Add(this.linkImgAltCheck);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(4, 164);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(758, 32);
            this.flowLayoutPanel6.TabIndex = 4;
            // 
            // linkImgLabel
            // 
            this.linkImgLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkImgLabel.Location = new System.Drawing.Point(4, 6);
            this.linkImgLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkImgLabel.Name = "linkImgLabel";
            this.linkImgLabel.Size = new System.Drawing.Size(203, 15);
            this.linkImgLabel.TabIndex = 0;
            this.linkImgLabel.Text = "\'リンク画像を枠で囲う\'実行時に";
            // 
            // linkImgAltCheck
            // 
            this.linkImgAltCheck.AutoSize = true;
            this.linkImgAltCheck.Location = new System.Drawing.Point(215, 4);
            this.linkImgAltCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.linkImgAltCheck.Name = "linkImgAltCheck";
            this.linkImgAltCheck.Size = new System.Drawing.Size(130, 19);
            this.linkImgAltCheck.TabIndex = 1;
            this.linkImgAltCheck.Text = "alt属性値を表示";
            this.linkImgAltCheck.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.imgAltFnameLabel);
            this.flowLayoutPanel7.Controls.Add(this.imgFnameCheck);
            this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(4, 204);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(758, 32);
            this.flowLayoutPanel7.TabIndex = 5;
            // 
            // imgAltFnameLabel
            // 
            this.imgAltFnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imgAltFnameLabel.Location = new System.Drawing.Point(4, 6);
            this.imgAltFnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imgAltFnameLabel.Name = "imgAltFnameLabel";
            this.imgAltFnameLabel.Size = new System.Drawing.Size(203, 15);
            this.imgAltFnameLabel.TabIndex = 0;
            this.imgAltFnameLabel.Text = "\'alt属性値を表示\'実行時に";
            // 
            // imgFnameCheck
            // 
            this.imgFnameCheck.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imgFnameCheck.AutoSize = true;
            this.imgFnameCheck.Location = new System.Drawing.Point(215, 4);
            this.imgFnameCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgFnameCheck.Name = "imgFnameCheck";
            this.imgFnameCheck.Size = new System.Drawing.Size(157, 19);
            this.imgFnameCheck.TabIndex = 1;
            this.imgFnameCheck.Text = "画像ファイル名を表示";
            this.imgFnameCheck.UseVisualStyleBackColor = true;
            // 
            // SettingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 305);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingDialog";
            this.Text = "設定";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button diagCancelButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label iePathLabel;
        private System.Windows.Forms.TextBox iePathText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label ffPathLabel;
        private System.Windows.Forms.TextBox ffPathText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label gcPathLabel;
        private System.Windows.Forms.TextBox gcPathText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label etcBrowserPathLabel;
        private System.Windows.Forms.TextBox etcBrowserText;
        private System.Windows.Forms.Button ieDefaultBtn;
        private System.Windows.Forms.Button ffDefaultBtn;
        private System.Windows.Forms.Button gcDefaultBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label linkImgLabel;
        private System.Windows.Forms.CheckBox linkImgAltCheck;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label imgAltFnameLabel;
        private System.Windows.Forms.CheckBox imgFnameCheck;
        private System.Windows.Forms.Button deleteSettingBtn;
        public System.Windows.Forms.Button diagOKButton;
    }
}