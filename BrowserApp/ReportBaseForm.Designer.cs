namespace BrowserApp
{
    partial class ReportBaseForm
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
            this.reportBaseStatusBar = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.reportBaseFormText = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.reportBaseFormCloseBtn = new System.Windows.Forms.Button();
            this.reportBaseStatusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.reportBaseStatusBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportBaseStatusBar
            // 
            this.reportBaseStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportBaseStatusBarLabel});
            this.reportBaseStatusBar.Location = new System.Drawing.Point(0, 373);
            this.reportBaseStatusBar.Name = "reportBaseStatusBar";
            this.reportBaseStatusBar.Size = new System.Drawing.Size(615, 22);
            this.reportBaseStatusBar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 373);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.reportBaseFormText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.27614F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.72386F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(615, 373);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // reportBaseFormText
            // 
            this.reportBaseFormText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportBaseFormText.Location = new System.Drawing.Point(3, 3);
            this.reportBaseFormText.Multiline = true;
            this.reportBaseFormText.Name = "reportBaseFormText";
            this.reportBaseFormText.Size = new System.Drawing.Size(609, 326);
            this.reportBaseFormText.TabIndex = 0;
            this.reportBaseFormText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.reportBaseFormText_KeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.Controls.Add(this.reportBaseFormCloseBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(265, 335);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(84, 35);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // reportBaseFormCloseBtn
            // 
            this.reportBaseFormCloseBtn.Location = new System.Drawing.Point(3, 3);
            this.reportBaseFormCloseBtn.Name = "reportBaseFormCloseBtn";
            this.reportBaseFormCloseBtn.Size = new System.Drawing.Size(75, 23);
            this.reportBaseFormCloseBtn.TabIndex = 0;
            this.reportBaseFormCloseBtn.Text = "閉じる";
            this.reportBaseFormCloseBtn.UseVisualStyleBackColor = true;
            this.reportBaseFormCloseBtn.Click += new System.EventHandler(this.reportBaseFormCloseBtn_Click);
            // 
            // reportBaseStatusBarLabel
            // 
            this.reportBaseStatusBarLabel.Name = "reportBaseStatusBarLabel";
            this.reportBaseStatusBarLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // ReportBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 395);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportBaseStatusBar);
            this.Name = "ReportBaseForm";
            this.Text = "BrowserApp レポート画面";
            this.reportBaseStatusBar.ResumeLayout(false);
            this.reportBaseStatusBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.StatusStrip reportBaseStatusBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.TextBox reportBaseFormText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button reportBaseFormCloseBtn;
        public System.Windows.Forms.ToolStripStatusLabel reportBaseStatusBarLabel;
    }
}