using System;
using System.Collections.Generic;
using System.Text;

namespace AllInOneConverter
{
    public class CoreConverter
    {
        public static string UrlEncode(string text, Encoding encoding)
        {
            /*
             * 先 对每个 字符 getBytes 汉字得 2个byte
             * 转16进制 
             * 前面 加上% 即可,即%xy%xy%xy，一个汉字占3位
             */           
            StringBuilder sb = new StringBuilder();
            byte[] byStr = encoding.GetBytes(text); //默认是System.Text.Encoding.Default.GetBytes(str)
            for (int i = 0; i < byStr.Length; i++)
            {
                sb.Append(@"%" + Convert.ToString(byStr[i], 16));
            }
            
            ////////
            //  2个版本各有千秋
            ////////

            //string unreservedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~";
            //StringBuilder sb = new StringBuilder();
            //foreach (Char item in text)
            //{
            //    if (unreservedChars.IndexOf(item) != -1)
            //    {
            //        sb.Append(item);
            //    }
            //    else
            //    {
            //        sb.Append('%' + String.Format("{0:X2}", (int)item));
            //    }
            //}

            return sb.ToString();
        }

        public static string UrlDecode(string text)
        {
            if (string.IsNullOrEmpty(text))
                return null;
           return  Uri.UnescapeDataString(text);            
        }


        //http://www.dotblogs.com.tw/nobel12/archive/2009/12/10/12367.aspx
        //base64
        //http://www.107000.com/


    }
}
