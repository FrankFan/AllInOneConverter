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
     * 主要包括
     * 1.Url编码&Url解码
     * 2.Base64编码&Base64解码
     * 3.\u类型Unicode转汉字&汉字转\u类型Unicode
     * 4.Md5加密，得到16位||32位结果
     * 
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Url编码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUrlEncode_Click(object sender, EventArgs e)
        {
            Encoding encoding;
            if (this.comboBox1.SelectedItem.ToString() == "UTF-8")
                encoding = Encoding.UTF8;
            else
                encoding = Encoding.Default;

            string text = txtUrlEncode.Text.Trim();
            string result = ConvertHelper.UrlEncode(text, encoding);
            txtUrlDecode.Text = result;
        }

        /// <summary>
        /// Url解码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUrlDecode_Click(object sender, EventArgs e)
        {
            Encoding encoding;
            if (this.comboBox1.SelectedItem.ToString() == "UTF-8")
                encoding = Encoding.UTF8;
            else
                encoding = Encoding.Default;

            string text = txtUrlDecode.Text.Trim();
            string result = ConvertHelper.UrlDecode(text, encoding);
            this.txtUrlEncode.Text = result;
        }

        /// <summary>
        /// \u形式Unicode编码转汉字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnicode2Chinese_Click(object sender, EventArgs e)
        {
            try
            {
                string text = this.txtUnicode.Text.Trim();
                string result = ConvertHelper.Unicode2Chinese(text);
                this.txtChinese.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unicode字符串格式不正确，是不是方向搞反了亲~\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 汉字转\u形式的Unicode字符
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChinese2Unicode_Click(object sender, EventArgs e)
        {
            string text = this.txtChinese.Text.Trim();
            string result = ConvertHelper.Chinese2Unicode(text);
            this.txtUnicode.Text = result;
        }

        /// <summary>
        /// Base64加密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBase64Encode_Click(object sender, EventArgs e)
        {
            string codeType = this.cmbBase64.SelectedItem.ToString();
            string text = this.txtBase64Encode.Text.Trim();
            string result = ConvertHelper.EncodeBase64(codeType, text);
            this.txtBase64Decode.Text = result;
        }

        /// <summary>
        /// Base64解密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBase64Decode_Click(object sender, EventArgs e)
        {
            string codeType = this.cmbBase64.SelectedItem.ToString();
            string text = this.txtBase64Decode.Text.Trim();
            string result = ConvertHelper.DecodeBase64(codeType, text);
            this.txtBase64Encode.Text = result;
        }

        //计算Md5值
        private void btnMd5_Click(object sender, EventArgs e)
        {
            string text = this.txtMd5.Text.Trim();
            string md5Str_32 = ConvertHelper.MD5(text, 32);
            this.txtMd5_32_Upper.Text = md5Str_32.ToUpper();
            this.txtMd5_32_Lower.Text = md5Str_32.ToLower();

            string md5Str_16 = ConvertHelper.MD5(text, 16);
            this.txtMd5_16_Upper.Text = md5Str_16.ToUpper();
            this.txtMd5_16_Lower.Text = md5Str_16.ToLower();

            // 16位MD5加密 正是32位Md5结构中取从第8个字符开始的16个字符

        }

        //小技巧：设计菜单时在快件字母前加上&就可以实现按住Alt+特定字母事件
        //如在退出菜单F→&F, X→&X, 就可以先按Alt激活菜单栏，再按字母键可以执行对应的方法
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("一个用于转换多种编码形式的小工具，方便使用，持续更新。\n作者： fanyong@gmail.com \n"));
        }

    }
}
