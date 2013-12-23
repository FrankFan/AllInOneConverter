using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AllInOneConverter
{
    /*
     * 目的：由于各种乱码问题导致编码错乱，开发一个编码转换器
     * 用于转换各种常见格式的编码。
     * 参考：
     * http://www.cnblogs.com/lijianwen/p/3475968.html
     * 
     * 
     * 
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUrlEncode_Click(object sender, EventArgs e)
        {
            Encoding encoding;
            if (this.comboBox1.SelectedItem.ToString() == "UTF-8")
                encoding = Encoding.UTF8;
            else
                encoding = Encoding.Default;

            string text = txtUrlEncode.Text.Trim();
            string result = CoreConverter.UrlEncode(text, encoding);
            txtUrlDecode.Text = result;
        }

        private void btnUrlDecode_Click(object sender, EventArgs e)
        {
            Encoding encoding;
            if (this.comboBox1.SelectedItem.ToString() == "UTF-8")
                encoding = Encoding.UTF8;
            else
                encoding = Encoding.Default;

            string text = txtUrlDecode.Text.Trim();
            string result = CoreConverter.UrlDecode(text, encoding);
            this.txtUrlEncode.Text = result;
        }

        private void btnUnicode2Chinese_Click(object sender, EventArgs e)
        {
            try
            {
                string text = this.txtUnicode.Text.Trim();
                string result = CoreConverter.Unicode2Chinese(text);
                this.txtChinese.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unicode字符串格式不正确\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChinese2Unicode_Click(object sender, EventArgs e)
        {
            string text = this.txtChinese.Text.Trim();
            string result = CoreConverter.Chinese2Unicode(text);
            this.txtUnicode.Text = result;
        }

        private void btnBase64Encode_Click(object sender, EventArgs e)
        {
            string codeType = this.cmbBase64.SelectedItem.ToString();
            string text = this.txtBase64Encode.Text.Trim();
            string result = CoreConverter.EncodeBase64(codeType, text);
            this.txtBase64Decode.Text = result;
        }

        private void btnBase64Decode_Click(object sender, EventArgs e)
        {
            string codeType = this.cmbBase64.SelectedItem.ToString();
            string text = this.txtBase64Decode.Text.Trim();
            string result = CoreConverter.DecodeBase64(codeType, text);
            this.txtBase64Encode.Text = result;
        }

        private void btnMd5_Click(object sender, EventArgs e)
        {
            string text = this.txtMd5.Text.Trim();
            string md5Str_32 = CoreConverter.MD5(text, 32);
            this.txtMd5_32_Upper.Text = md5Str_32.ToUpper();
            this.txtMd5_32_Lower.Text = md5Str_32.ToLower();

            string md5Str_16 = CoreConverter.MD5(text, 16);
            this.txtMd5_16_Upper.Text = md5Str_16.ToUpper();
            this.txtMd5_16_Lower.Text = md5Str_16.ToLower();

            // 16位MD5加密 正是32位Md5结构中取从第8个字符开始的16个字符

        }

    }
}
