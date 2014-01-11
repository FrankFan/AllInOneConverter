namespace AllInOneConverter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtUrlDecode = new System.Windows.Forms.TextBox();
            this.txtUrlEncode = new System.Windows.Forms.TextBox();
            this.btnUrlDecode = new System.Windows.Forms.Button();
            this.btnUrlEncode = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtBase64Decode = new System.Windows.Forms.TextBox();
            this.txtBase64Encode = new System.Windows.Forms.TextBox();
            this.btnBase64Decode = new System.Windows.Forms.Button();
            this.btnBase64Encode = new System.Windows.Forms.Button();
            this.cmbBase64 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnChinese2Unicode = new System.Windows.Forms.Button();
            this.btnUnicode2Chinese = new System.Windows.Forms.Button();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.txtUnicode = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMd5 = new System.Windows.Forms.Button();
            this.txtMd5_16_Lower = new System.Windows.Forms.TextBox();
            this.txtMd5_16_Upper = new System.Windows.Forms.TextBox();
            this.txtMd5_32_Lower = new System.Windows.Forms.TextBox();
            this.txtMd5_32_Upper = new System.Windows.Forms.TextBox();
            this.txtMd5 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(577, 350);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtUrlDecode);
            this.tabPage1.Controls.Add(this.txtUrlEncode);
            this.tabPage1.Controls.Add(this.btnUrlDecode);
            this.tabPage1.Controls.Add(this.btnUrlEncode);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(569, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Url编码解码";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtUrlDecode
            // 
            this.txtUrlDecode.Location = new System.Drawing.Point(39, 197);
            this.txtUrlDecode.Multiline = true;
            this.txtUrlDecode.Name = "txtUrlDecode";
            this.txtUrlDecode.Size = new System.Drawing.Size(465, 80);
            this.txtUrlDecode.TabIndex = 0;
            // 
            // txtUrlEncode
            // 
            this.txtUrlEncode.Location = new System.Drawing.Point(39, 34);
            this.txtUrlEncode.Multiline = true;
            this.txtUrlEncode.Name = "txtUrlEncode";
            this.txtUrlEncode.Size = new System.Drawing.Size(465, 80);
            this.txtUrlEncode.TabIndex = 0;
            // 
            // btnUrlDecode
            // 
            this.btnUrlDecode.Location = new System.Drawing.Point(383, 149);
            this.btnUrlDecode.Name = "btnUrlDecode";
            this.btnUrlDecode.Size = new System.Drawing.Size(75, 23);
            this.btnUrlDecode.TabIndex = 2;
            this.btnUrlDecode.Text = "解码↑";
            this.btnUrlDecode.UseVisualStyleBackColor = true;
            this.btnUrlDecode.Click += new System.EventHandler(this.btnUrlDecode_Click);
            // 
            // btnUrlEncode
            // 
            this.btnUrlEncode.Location = new System.Drawing.Point(210, 149);
            this.btnUrlEncode.Name = "btnUrlEncode";
            this.btnUrlEncode.Size = new System.Drawing.Size(75, 23);
            this.btnUrlEncode.TabIndex = 2;
            this.btnUrlEncode.Text = "编码↓";
            this.btnUrlEncode.UseVisualStyleBackColor = true;
            this.btnUrlEncode.Click += new System.EventHandler(this.btnUrlEncode_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "UTF-8",
            "GB2312"});
            this.comboBox1.Location = new System.Drawing.Point(61, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "UTF-8";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtBase64Decode);
            this.tabPage2.Controls.Add(this.txtBase64Encode);
            this.tabPage2.Controls.Add(this.btnBase64Decode);
            this.tabPage2.Controls.Add(this.btnBase64Encode);
            this.tabPage2.Controls.Add(this.cmbBase64);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(569, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Base64编码解码";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtBase64Decode
            // 
            this.txtBase64Decode.Location = new System.Drawing.Point(42, 198);
            this.txtBase64Decode.Multiline = true;
            this.txtBase64Decode.Name = "txtBase64Decode";
            this.txtBase64Decode.Size = new System.Drawing.Size(465, 80);
            this.txtBase64Decode.TabIndex = 3;
            // 
            // txtBase64Encode
            // 
            this.txtBase64Encode.Location = new System.Drawing.Point(42, 35);
            this.txtBase64Encode.Multiline = true;
            this.txtBase64Encode.Name = "txtBase64Encode";
            this.txtBase64Encode.Size = new System.Drawing.Size(465, 80);
            this.txtBase64Encode.TabIndex = 4;
            // 
            // btnBase64Decode
            // 
            this.btnBase64Decode.Location = new System.Drawing.Point(358, 150);
            this.btnBase64Decode.Name = "btnBase64Decode";
            this.btnBase64Decode.Size = new System.Drawing.Size(91, 23);
            this.btnBase64Decode.TabIndex = 6;
            this.btnBase64Decode.Text = "Base64解码↑";
            this.btnBase64Decode.UseVisualStyleBackColor = true;
            this.btnBase64Decode.Click += new System.EventHandler(this.btnBase64Decode_Click);
            // 
            // btnBase64Encode
            // 
            this.btnBase64Encode.Location = new System.Drawing.Point(213, 150);
            this.btnBase64Encode.Name = "btnBase64Encode";
            this.btnBase64Encode.Size = new System.Drawing.Size(91, 23);
            this.btnBase64Encode.TabIndex = 7;
            this.btnBase64Encode.Text = "Base64编码↓";
            this.btnBase64Encode.UseVisualStyleBackColor = true;
            this.btnBase64Encode.Click += new System.EventHandler(this.btnBase64Encode_Click);
            // 
            // cmbBase64
            // 
            this.cmbBase64.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbBase64.FormattingEnabled = true;
            this.cmbBase64.Items.AddRange(new object[] {
            "UTF-8",
            "GB2312"});
            this.cmbBase64.Location = new System.Drawing.Point(64, 150);
            this.cmbBase64.Name = "cmbBase64";
            this.cmbBase64.Size = new System.Drawing.Size(79, 23);
            this.cmbBase64.TabIndex = 5;
            this.cmbBase64.Text = "UTF-8";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnChinese2Unicode);
            this.tabPage3.Controls.Add(this.btnUnicode2Chinese);
            this.tabPage3.Controls.Add(this.txtChinese);
            this.tabPage3.Controls.Add(this.txtUnicode);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(569, 324);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "\\u Unicode编码解码";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnChinese2Unicode
            // 
            this.btnChinese2Unicode.Location = new System.Drawing.Point(243, 189);
            this.btnChinese2Unicode.Name = "btnChinese2Unicode";
            this.btnChinese2Unicode.Size = new System.Drawing.Size(75, 44);
            this.btnChinese2Unicode.TabIndex = 1;
            this.btnChinese2Unicode.Text = "←汉字转Unicode";
            this.btnChinese2Unicode.UseVisualStyleBackColor = true;
            this.btnChinese2Unicode.Click += new System.EventHandler(this.btnChinese2Unicode_Click);
            // 
            // btnUnicode2Chinese
            // 
            this.btnUnicode2Chinese.Location = new System.Drawing.Point(243, 65);
            this.btnUnicode2Chinese.Name = "btnUnicode2Chinese";
            this.btnUnicode2Chinese.Size = new System.Drawing.Size(75, 45);
            this.btnUnicode2Chinese.TabIndex = 1;
            this.btnUnicode2Chinese.Text = "Unicode转汉字→";
            this.btnUnicode2Chinese.UseVisualStyleBackColor = true;
            this.btnUnicode2Chinese.Click += new System.EventHandler(this.btnUnicode2Chinese_Click);
            // 
            // txtChinese
            // 
            this.txtChinese.Location = new System.Drawing.Point(343, 17);
            this.txtChinese.Multiline = true;
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(206, 272);
            this.txtChinese.TabIndex = 0;
            // 
            // txtUnicode
            // 
            this.txtUnicode.Location = new System.Drawing.Point(14, 17);
            this.txtUnicode.Multiline = true;
            this.txtUnicode.Name = "txtUnicode";
            this.txtUnicode.Size = new System.Drawing.Size(206, 272);
            this.txtUnicode.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.btnMd5);
            this.tabPage4.Controls.Add(this.txtMd5_16_Lower);
            this.tabPage4.Controls.Add(this.txtMd5_16_Upper);
            this.tabPage4.Controls.Add(this.txtMd5_32_Lower);
            this.tabPage4.Controls.Add(this.txtMd5_32_Upper);
            this.tabPage4.Controls.Add(this.txtMd5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(569, 324);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Md5加密";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "16位加密";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "32位加密";
            // 
            // btnMd5
            // 
            this.btnMd5.Location = new System.Drawing.Point(214, 79);
            this.btnMd5.Name = "btnMd5";
            this.btnMd5.Size = new System.Drawing.Size(75, 23);
            this.btnMd5.TabIndex = 1;
            this.btnMd5.Text = "Md5加密";
            this.btnMd5.UseVisualStyleBackColor = true;
            this.btnMd5.Click += new System.EventHandler(this.btnMd5_Click);
            // 
            // txtMd5_16_Lower
            // 
            this.txtMd5_16_Lower.Location = new System.Drawing.Point(35, 279);
            this.txtMd5_16_Lower.Name = "txtMd5_16_Lower";
            this.txtMd5_16_Lower.Size = new System.Drawing.Size(490, 21);
            this.txtMd5_16_Lower.TabIndex = 0;
            // 
            // txtMd5_16_Upper
            // 
            this.txtMd5_16_Upper.Location = new System.Drawing.Point(35, 242);
            this.txtMd5_16_Upper.Name = "txtMd5_16_Upper";
            this.txtMd5_16_Upper.Size = new System.Drawing.Size(490, 21);
            this.txtMd5_16_Upper.TabIndex = 0;
            // 
            // txtMd5_32_Lower
            // 
            this.txtMd5_32_Lower.Location = new System.Drawing.Point(35, 180);
            this.txtMd5_32_Lower.Name = "txtMd5_32_Lower";
            this.txtMd5_32_Lower.Size = new System.Drawing.Size(490, 21);
            this.txtMd5_32_Lower.TabIndex = 0;
            // 
            // txtMd5_32_Upper
            // 
            this.txtMd5_32_Upper.Location = new System.Drawing.Point(35, 143);
            this.txtMd5_32_Upper.Name = "txtMd5_32_Upper";
            this.txtMd5_32_Upper.Size = new System.Drawing.Size(490, 21);
            this.txtMd5_32_Upper.TabIndex = 0;
            // 
            // txtMd5
            // 
            this.txtMd5.Location = new System.Drawing.Point(35, 36);
            this.txtMd5.Name = "txtMd5";
            this.txtMd5.Size = new System.Drawing.Size(490, 21);
            this.txtMd5.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ExitToolStripMenuItem.Text = "退出(&X)";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.AboutToolStripMenuItem.Text = "关于(&A)";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 395);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "All in One Conveter   By fanyong@gmail.com";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnUrlDecode;
        private System.Windows.Forms.Button btnUrlEncode;
        private System.Windows.Forms.TextBox txtUrlEncode;
        private System.Windows.Forms.TextBox txtUrlDecode;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.TextBox txtUnicode;
        private System.Windows.Forms.Button btnChinese2Unicode;
        private System.Windows.Forms.Button btnUnicode2Chinese;
        private System.Windows.Forms.TextBox txtBase64Decode;
        private System.Windows.Forms.TextBox txtBase64Encode;
        private System.Windows.Forms.Button btnBase64Decode;
        private System.Windows.Forms.Button btnBase64Encode;
        private System.Windows.Forms.ComboBox cmbBase64;
        private System.Windows.Forms.Button btnMd5;
        private System.Windows.Forms.TextBox txtMd5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMd5_16_Lower;
        private System.Windows.Forms.TextBox txtMd5_16_Upper;
        private System.Windows.Forms.TextBox txtMd5_32_Lower;
        private System.Windows.Forms.TextBox txtMd5_32_Upper;
    }
}

