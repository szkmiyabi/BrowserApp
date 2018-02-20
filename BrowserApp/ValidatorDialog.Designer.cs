namespace BrowserApp
{
    partial class ValidatorDialog
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
            this.validatorReportArea = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.validatorDialogCloseButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.validatorReportArea, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.19553F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.80447F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(670, 358);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // validatorReportArea
            // 
            this.validatorReportArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.validatorReportArea.Location = new System.Drawing.Point(3, 3);
            this.validatorReportArea.Multiline = true;
            this.validatorReportArea.Name = "validatorReportArea";
            this.validatorReportArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.validatorReportArea.Size = new System.Drawing.Size(664, 299);
            this.validatorReportArea.TabIndex = 0;
            this.validatorReportArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.validatorReportArea_KeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.validatorDialogCloseButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(274, 308);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(393, 47);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // validatorDialogCloseButton
            // 
            this.validatorDialogCloseButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.validatorDialogCloseButton.Location = new System.Drawing.Point(3, 3);
            this.validatorDialogCloseButton.Name = "validatorDialogCloseButton";
            this.validatorDialogCloseButton.Size = new System.Drawing.Size(75, 23);
            this.validatorDialogCloseButton.TabIndex = 0;
            this.validatorDialogCloseButton.Text = "閉じる";
            this.validatorDialogCloseButton.UseVisualStyleBackColor = true;
            // 
            // ValidatorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 358);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ValidatorDialog";
            this.Text = "HTML Validator レポート生成";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button validatorDialogCloseButton;
        public System.Windows.Forms.TextBox validatorReportArea;
    }
}