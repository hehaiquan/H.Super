namespace Demo.WinForm
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpQrCode = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGenerateQrCode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxQRImage = new System.Windows.Forms.PictureBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpQrCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQRImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpQrCode);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(749, 469);
            this.tabControl1.TabIndex = 1;
            // 
            // tpQrCode
            // 
            this.tpQrCode.Controls.Add(this.txtContent);
            this.tpQrCode.Controls.Add(this.label2);
            this.tpQrCode.Controls.Add(this.txtSize);
            this.tpQrCode.Controls.Add(this.picBoxQRImage);
            this.tpQrCode.Controls.Add(this.label1);
            this.tpQrCode.Controls.Add(this.btnGenerateQrCode);
            this.tpQrCode.Location = new System.Drawing.Point(4, 22);
            this.tpQrCode.Name = "tpQrCode";
            this.tpQrCode.Padding = new System.Windows.Forms.Padding(3);
            this.tpQrCode.Size = new System.Drawing.Size(741, 443);
            this.tpQrCode.TabIndex = 0;
            this.tpQrCode.Text = "二维码";
            this.tpQrCode.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1001, 668);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGenerateQrCode
            // 
            this.btnGenerateQrCode.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGenerateQrCode.Location = new System.Drawing.Point(590, 91);
            this.btnGenerateQrCode.Name = "btnGenerateQrCode";
            this.btnGenerateQrCode.Size = new System.Drawing.Size(142, 48);
            this.btnGenerateQrCode.TabIndex = 0;
            this.btnGenerateQrCode.Text = "生成二维码";
            this.btnGenerateQrCode.UseVisualStyleBackColor = true;
            this.btnGenerateQrCode.Click += new System.EventHandler(this.btnGenerateQrCode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "大小：";
            // 
            // picBoxQRImage
            // 
            this.picBoxQRImage.Location = new System.Drawing.Point(12, 145);
            this.picBoxQRImage.Name = "picBoxQRImage";
            this.picBoxQRImage.Size = new System.Drawing.Size(720, 290);
            this.picBoxQRImage.TabIndex = 2;
            this.picBoxQRImage.TabStop = false;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(67, 19);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 21);
            this.txtSize.TabIndex = 3;
            this.txtSize.Text = "4";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(65, 64);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(488, 21);
            this.txtContent.TabIndex = 5;
            this.txtContent.Text = "http://www.baidu.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "内容：";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 469);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Main";
            this.tabControl1.ResumeLayout(false);
            this.tpQrCode.ResumeLayout(false);
            this.tpQrCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQRImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpQrCode;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.PictureBox picBoxQRImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerateQrCode;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

