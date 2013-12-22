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
            string text = txtUrlDecode.Text.Trim();
            string result = CoreConverter.UrlDecode(text);
            this.txtUrlEncode.Text = result;
        }
    }
}
