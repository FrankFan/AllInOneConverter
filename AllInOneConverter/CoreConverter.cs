using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace AllInOneConverter
{
    /// <summary>
    /// 该类提供各种编码的来回之间的转换方式
    /// </summary>
    public class CoreConverter
    {

        public static string UrlEncode(string text, Encoding encoding)
        {
            return HttpUtility.UrlEncode(text, encoding);

            /*
             * 先 对每个 字符 getBytes 汉字得 2个byte
             * 转16进制 
             * 前面 加上% 即可,即%xy%xy%xy，unicode一个汉字占3位,gbk一个汉字占2位
             */

            //版本1：
            //StringBuilder sb = new StringBuilder();
            //byte[] byStr = encoding.GetBytes(text); //默认是System.Text.Encoding.Default.GetBytes(str)
            //for (int i = 0; i < byStr.Length; i++)
            //{
            //    sb.Append(@"%" + Convert.ToString(byStr[i], 16));
            //}

            

            // 版本2
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

            //return sb.ToString();
        }

        public static string UrlDecode(string text, Encoding encoding)
        {
            if (string.IsNullOrEmpty(text))
                return null;

            return HttpUtility.UrlDecode(text, encoding);

            //版本2
            //return  Uri.UnescapeDataString(text);            
        }

        /// <summary>
        /// 进行Base64编码
        /// </summary>
        /// <param name="codeType">编码方式</param>
        /// <param name="code">编码文本</param>
        /// <returns>返回Base64字符串</returns>
        public static string EncodeBase64(string codeType, string code)
        {
            string encode = "";
            byte[] bytes = System.Text.Encoding.GetEncoding(codeType).GetBytes(code);

            try
            {
                encode = System.Convert.ToBase64String(bytes);
            }
            catch
            {
                encode = code;
            }
            return encode;
        }

        /// <summary>
        ///  进行Base64解码
        /// </summary>
        /// <param name="codeType">编码方式</param>
        /// <param name="code">待解码字符串</param>
        /// <returns>返回解码后的字符串</returns>
        public static string DecodeBase64(string codeType, string code)
        {
            string decode = "";
            byte[] bytes = System.Convert.FromBase64String(code);
            try
            {
                decode = System.Text.Encoding.GetEncoding(codeType).GetString(bytes);
            }
            catch
            {
                decode = code;
            }
            return decode;
        }

        /// <summary>
        /// 把\u形式的unicode字符转成汉字
        /// </summary>
        /// <param name="strUnicode"></param>
        /// <returns></returns>
        public static string Unicode2Chinese(string strUnicode)
        {
            string[] splitString = new string[1];
            splitString[0] = "\\u";
            string[] unicodeArray = strUnicode.Split(splitString, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();

            foreach (string item in unicodeArray)
            {
                byte[] codes = new byte[2];
                int code1, code2;
                code1 = Convert.ToInt32(item.Substring(0, 2), 16);
                code2 = Convert.ToInt32(item.Substring(2), 16);
                codes[0] = (byte)code2;//必须是小端在前
                codes[1] = (byte)code1;
                sb.Append(Encoding.Unicode.GetString(codes));
            }

            return sb.ToString();
        }

        /// <summary>
        /// 把汉字转成十六进制表示的\u形式的字符串
        /// </summary>
        /// <param name="strChinese"></param>
        /// <returns></returns>
        public static string Chinese2Unicode(string strChinese)
        {
            string strUnicodes = string.Empty;
            foreach (char item in strChinese.ToCharArray())
            {
                strUnicodes += "\\u" + ((int)item).ToString("x"); //16进制
            }
            return strUnicodes;
        }

        ///<summary>
        /// MD5加密函数
        ///</summary>
        ///<param name="toCryString"></param>
        ///<returns></returns>
        public static string MD5(string text,int length)
        {
            string encrytStr = string.Empty;
            MD5CryptoServiceProvider hashmd5;
            hashmd5 = new MD5CryptoServiceProvider();
            encrytStr = BitConverter.ToString(hashmd5.ComputeHash(Encoding.Default.GetBytes(text.ToCharArray()))).Replace("-", "").ToLower();   
            //将所有字母变小写
            if (length == 16)
            {
                encrytStr = encrytStr.Substring(8, 16).ToLower();
            }

            return encrytStr;
        }

    }
}
