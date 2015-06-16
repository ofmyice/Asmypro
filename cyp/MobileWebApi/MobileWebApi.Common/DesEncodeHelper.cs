using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MobileWebApi.Common
{
    /// <summary>
    ///  DES解密 加密
    /// </summary>
   public class DesEncodeHelper
    {
       /// <summary>
       /// DES加密
       /// </summary>
       /// <param name="pToEncrypt"></param>
       /// <param name="key"></param>
       /// <returns></returns>
       public static string Key
       {
           get
           {
               string key = System.Configuration.ConfigurationManager.AppSettings["AndroidKey"] != null ? System.Configuration.ConfigurationManager.AppSettings["AndroidKey"].ToString() : "dfcyp2co";
               return key;
           }
       }
       /// <summary>
       /// 加密
       /// </summary>
       /// <param name="pToEncrypt"></param>
       /// <param name="key"></param>
       /// <returns></returns>
       public static  string DESEnCode(string pToEncrypt, string key)
        {
           try
           {
               pToEncrypt = HttpContext.Current.Server.UrlEncode(pToEncrypt);
               DESCryptoServiceProvider des = new DESCryptoServiceProvider();
               byte[] inputByteArray = Encoding.GetEncoding("UTF-8").GetBytes(pToEncrypt);

               des.Key = ASCIIEncoding.ASCII.GetBytes(key);
               des.IV = ASCIIEncoding.ASCII.GetBytes(key);
               MemoryStream ms = new MemoryStream();
               CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);

               cs.Write(inputByteArray, 0, inputByteArray.Length);
               cs.FlushFinalBlock();

               StringBuilder ret = new StringBuilder();
               foreach (byte b in ms.ToArray())
               {
                   ret.AppendFormat("{0:X2}", b);
               }
               return ret.ToString();
           }
           catch
           {
               return "";
           }
           
        }
       /// <summary>
       /// 解密
       /// </summary>
       /// <param name="pToDecrypt"></param>
       /// <param name="key"></param>
       /// <returns></returns>
        public static string DESDeCode(string pToDecrypt, string key)
        {
           try
           {
               DESCryptoServiceProvider des = new DESCryptoServiceProvider();

               byte[] inputByteArray = new byte[pToDecrypt.Length / 2];
               for (int x = 0; x < pToDecrypt.Length / 2; x++)
               {
                   int i = (Convert.ToInt32(pToDecrypt.Substring(x * 2, 2), 16));
                   inputByteArray[x] = (byte)i;
               }
               des.Key = ASCIIEncoding.ASCII.GetBytes(key);
               des.IV = ASCIIEncoding.ASCII.GetBytes(key);
               MemoryStream ms = new MemoryStream();
               CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
               cs.Write(inputByteArray, 0, inputByteArray.Length);
               cs.FlushFinalBlock();
               StringBuilder ret = new StringBuilder();
               return HttpContext.Current.Server.UrlDecode(System.Text.Encoding.Default.GetString(ms.ToArray()));   
           }
           catch
           {
               return pToDecrypt;
           }
                      
        }
    }
}
