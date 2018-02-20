namespace BrowserApp
{
    partial class LinkListDialog
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LinkListTextArea = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkListStatusLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkDialogCloseButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LinkListTextArea, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.66454F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.33546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(733, 313);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LinkListTextArea
            // 
            this.LinkListTextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LinkListTextArea.Location = new System.Drawing.Point(3, 3);
            this.LinkListTextArea.Multiline = true;
            this.LinkListTextArea.Name = "LinkListTextArea";
            this.LinkListTextArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LinkListTextArea.Size = new System.Drawing.Size(727, 259);
            this.LinkListTextArea.TabIndex = 0;
            this.LinkListTextArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LinkListTextArea_KeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 268);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(727, 42);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.linkListStatusLabel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(406, 43);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // linkListStatusLabel
            // 
            this.linkListStatusLabel.AutoSize = true;
            this.linkListStatusLabel.Location = new System.Drawing.Point(5, 5);
            this.linkListStatusLabel.Margin = new System.Windows.Forms.Padding(5);
            this.linkListStatusLabel.Name = "linkListStatusLabel";
            this.linkListStatusLabel.Size = new System.Drawing.Size(35, 12);
            this.linkListStatusLabel.TabIndex = 0;
            this.linkListStatusLabel.Text = "label1";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.linkDialogCloseButton);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(415, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(277, 43);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // linkDialogCloseButton
            // 
            this.linkDialogCloseButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.linkDialogCloseButton.Location = new System.Drawing.Point(3, 3);
            this.linkDialogCloseButton.Name = "linkDialogCloseButton";
            this.linkDialogCloseButton.Size = new System.Drawing.Size(75, 23);
            this.linkDialogCloseButton.TabIndex = 0;
            this.linkDialogCloseButton.Text = "閉じる";
            this.linkDialogCloseButton.UseVisualStyleBackColor = true;
            // 
            // LinkListDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 313);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LinkListDialog";
            this.Text = "リンク一覧を表示";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.TextBox LinkListTextArea;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button linkDialogCloseButton;
        public System.Windows.Forms.Label linkListStatusLabel;
    }
}