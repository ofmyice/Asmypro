using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;

namespace MobileWebApi.Common
{
    public class Utils
    {
        //判断用户名
        public static bool IsUserName(string str)
        {
            if (str == null) return false;
            if (StrLength(str) < 3 || StrLength(str) > 20) return false;
            return (Regex.IsMatch(str, @"^[^`~!@#$%^&*()+=|\\\[\]\{\}:;\'""\/\,.<>? 　]{3,20}$"));
        }
        public static bool IsUserNameBenz(string str)
        {
            if (str == null) return false;
            if (StrLength(str) < 8 || StrLength(str) > 20) return false;
            return (Regex.IsMatch(str, @"^[^`~!@#$%^&*()+=|\\\[\]\{\}:;\'""\/\,.<>? 　]{8,20}$"));
        }

        //判断姓名（中文或英文）
        public static bool IsRealName(string str)
        {
            if (str == null) return false;
            str = str.Trim();
            return (Regex.IsMatch(str, @"^[(\u4e00-\u9fa5)|(a-zA-Z )]{2,20}$"));
        }

        //判断密码
        public static bool IsPassword(string str)
        {
            if (str == null) return false;
            return (Regex.IsMatch(str, @"^[a-zA-Z0-9\-_\.\!\@\#\$\^\*]{6,20}$"));
        }
        public static bool IsPasswordBenz(string str)
        {
            if (str == null) return false;
            if (StrLength(str) < 8 || StrLength(str) > 12) return false;
            if (!Regex.IsMatch(str, @"\d+")) return false;
            if (!Regex.IsMatch(str, @"[a-zA-Z]+")) return false;
            if (!Regex.IsMatch(str, @"[~`\-=+_.!\@\#\$\%\^\/\&\*\(\)\[\]\{\}\;\'\:\,\?\<\>]+")) return false;
            return true;
        }

        /// <summary>
        /// 校验商户名称为 2-16个字符
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsCompanyName(string str)
        {
            if (str == null) return false;
            if (StrLength(str) < 2 || StrLength(str) > 16) return false;
            return (Regex.IsMatch(str, @"^[(\w\u4e00-\u9fa5)]{2,16}$"));//(Regex.IsMatch(str, @"/^[\w\u4E00-\u9FA5\uf900-\ufa2d]{2,16}$/"));
        }

        //判断Email
        public static bool IsEmail(string str)
        {
            if (str == null) return false;
            return (Regex.IsMatch(str, @"[_a-zA-Z\d\-\.]+@[_a-zA-Z\d\-]+(\.[_a-zA-Z\d\-]+)+$"));
        }

        //获取字符串长度
        public static int StrLength(string str)
        {
            byte[] strArray = System.Text.Encoding.Default.GetBytes(str);
            return strArray.Length;
        }

        //判断手机号码
        public static bool IsMobilePhone(string str)
        {
            if (str == null) return false;
            return (Regex.IsMatch(str, @"^((1)(3|5|8)[0-9]{9})$"));
        }

        //判断是否为整数
        public static bool IsInt(string str)
        {
            if (str == null) return false;
            return (Regex.IsMatch(str, @"^[1-9]{1}[0-9]{0,10}$"));
        }

        //判断日期
        public static bool IsDate(string str)
        {
            if (str == null) return false;
            try
            {
                DateTime result = Convert.ToDateTime(str);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //MD5加密
        public static string MD5(string str)
        {
            if (str == null) return "";
            return FormsAuthentication.HashPasswordForStoringInConfigFile(str, "md5");
        }

        //判断是否为IP地址
        private static bool IsIPAddress(string str)
        {
            if (str == null || str == string.Empty || str.Length < 7 || str.Length > 15) return false;
            string regformat = @"^\d{1,3}[\.]\d{1,3}[\.]\d{1,3}[\.]\d{1,3}$";
            Regex regex = new Regex(regformat, RegexOptions.IgnoreCase);
            return regex.IsMatch(str);
        }

        //获取客户端真实IP，如果有代理则取第一个非内网地址
        public static string IPAddress
        {
            get
            {
                string result = String.Empty;
                result = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                if (result != null && result != String.Empty)
                {
                    if (result.IndexOf(".") == -1)
                        result = null;
                    else
                    {
                        if (result.IndexOf(",") != -1)
                        {
                            result = result.Replace(" ", "").Replace("'", "");
                            string[] temparyip = result.Split(",;".ToCharArray());
                            for (int i = 0; i < temparyip.Length; i++)
                            {
                                if (IsIPAddress(temparyip[i])
                                    && temparyip[i].Substring(0, 3) != "10."
                                    && temparyip[i].Substring(0, 7) != "192.168"
                                    && temparyip[i].Substring(0, 7) != "172.16.")
                                {
                                    return temparyip[i];
                                }
                            }
                        }
                        else if (IsIPAddress(result))
                            return result;
                        else
                            result = null;
                    }
                }
                result = (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null && HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != String.Empty) ? HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] : HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                if (null == result || result == String.Empty)
                    result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                if (result == null || result == String.Empty)
                    result = HttpContext.Current.Request.UserHostAddress;
                if (result == "::1") result = "127.0.0.1";
                return result;
            }
        }

        public static bool InArrayList(ArrayList List, string val)
        {
            if (string.IsNullOrEmpty(val)) return false;
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].ToString() == val) return true;
            }
            return false;
        }

        public static bool InArrayNumber(string strlong, string strshort)
        {
            if (strlong == "" || strshort == "") return false;
            strshort = "," + strshort.Trim() + ",";
            strlong = "," + strlong + ",";
            return (strlong.IndexOf(strshort) > -1);
        }

        //查询编码
        public static bool IsTradeCode(string str)
        {
            if (str == null) return false;
            return (Regex.IsMatch(str, @"^[a-zA-Z]{3}[\d]{10}$"));
        }

        //格式化金额
        public static string FormatMoney(string str)
        {
            if (!IsInt(str)) return "";
            return Convert.ToInt32(str).ToString("###,###,###");
        }

        //人民币大写
        public static string FormatMoneyCN(string num)
        {
            if (num == null) return "";
            num = num.Trim().Replace(",", "");
            //if (!Regex.IsMatch(num, @"^[1-9]{1}[0-9]{0,9}$")) return "";

            string[] part = num.Split('.');
            string newchar = "", tmpnewchar;
            char perchar;

            string[] BB = "零,壹,贰,叁,肆,伍,陆,柒,捌,玖".Split(',');
            for (int i = part[0].Length - 1; i >= 0; i--)
            {
                perchar = part[0][i];
                tmpnewchar = BB[Convert.ToInt32(part[0].Substring(i, 1))];
                switch (part[0].Length - i - 1)
                {
                    case 0:
                        tmpnewchar += "元";
                        break;
                    case 1:
                        if (perchar != '0') tmpnewchar += "拾";
                        break;
                    case 2:
                        if (perchar != '0') tmpnewchar += "佰";
                        break;
                    case 3:
                        if (perchar != '0') tmpnewchar += "仟";
                        break;
                    case 4:
                        tmpnewchar += "万";
                        break;
                    case 5:
                        if (perchar != '0') tmpnewchar += "拾";
                        break;
                    case 6:
                        if (perchar != '0') tmpnewchar += "佰";
                        break;
                    case 7:
                        if (perchar != '0') tmpnewchar += "仟";
                        break;
                    case 8:
                        tmpnewchar += "亿";
                        break;
                    case 9:
                        tmpnewchar += "拾";
                        break;
                }
                newchar = tmpnewchar + newchar;
            }

            //小数点之后进行转化
            if (num.IndexOf(".") != -1)
            {
                //小数点之后只能保留两位,系统将自动截段
                if (part[1].Length > 2) { part[1] = part[1].Substring(0, 2); }

                for (int i = 0; i < part[1].Length; i++)
                {
                    tmpnewchar = BB[Convert.ToInt32(part[1].Substring(i, 1))];
                    if (i == 0) tmpnewchar += "角";
                    if (i == 1) tmpnewchar += "分";
                    newchar += tmpnewchar;
                }
            }

            //替换所有无用汉字
            while (newchar.IndexOf("零零") != -1) newchar = newchar.Replace("零零", "零");
            newchar = newchar.Replace("零亿", "亿");
            newchar = newchar.Replace("亿万", "亿");
            newchar = newchar.Replace("零万", "万");
            newchar = newchar.Replace("零元", "元");
            newchar = newchar.Replace("零角", "");
            newchar = newchar.Replace("零分", "");

            if (newchar.EndsWith("元") || newchar.EndsWith("角")) newchar += "整";

            return newchar;
        }

        //判断是否为奔驰域名
        public static bool IsBenzSite()
        {
            string str = HttpContext.Current.Request.Url.Authority;
            return (str.Equals("mercedes-benz.268v.com"));
        }

        public static void Msg(string str)
        {
            HttpContext.Current.Response.Write("<script>alert('" + str + "');self.history.back();</script>");
            HttpContext.Current.Response.End();
        }

        public static void Msg2(string str, string url)
        {
            HttpContext.Current.Response.Write("<script>alert('" + str + "');self.location.replace('" + url + "');</script>");
            HttpContext.Current.Response.End();
        }

        public static string Escape(string str)
        {
            if (str == null) return String.Empty;

            StringBuilder sb = new StringBuilder();
            int len = str.Length;
            for (int i = 0; i < len; i++)
            {
                char c = str[i];
                //everything other than the optionally escaped chars _must_ be escaped 
                if (Char.IsLetterOrDigit(c) || c == '-' || c == '_' || c == '/' || c == '\\' || c == '.')
                    sb.Append(c);
                else
                    sb.Append(Uri.HexEscape(c));
            }
            return sb.ToString();
        }

        public static string UnEscape(string str)
        {
            if (str == null) return String.Empty;
            StringBuilder sb = new StringBuilder();
            int len = str.Length;
            int i = 0;
            while (i != len)
            {
                if (Uri.IsHexEncoding(str, i))
                    sb.Append(Uri.HexUnescape(str, ref i));
                else
                    sb.Append(str[i++]);
            }
            return sb.ToString();
        }

        #region 区分中英文的字符串截取
        /// <summary>
        /// 区分中英文的字符串截取
        /// </summary>
        /// <param name="inputString"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static string GetChineseSubString(string inputString, int count)
        {
            return GetChineseSubString(inputString, count, "..");
        }
        public static string GetChineseSubString(string inputString, int count, string addition)
        {
            int limit = count * 2;
            if (limit >= GetChineseStringLength(inputString))
            {
                return inputString;
            }
            else
            {
                limit -= addition.Length;
                StringBuilder sb = new StringBuilder();
                char[] chars = inputString.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    char c = chars[i];
                    sb.Append(c);
                    if (c > 127)
                    {
                        limit -= 2;
                        if (limit < 0)
                        {
                            sb.Length--;
                            break;
                        }
                    }
                    else
                    {
                        limit--;
                    }
                    if (limit == 0)
                    {
                        break;
                    }
                }
                return sb.ToString() + addition;
            }
        }

        public static int GetChineseStringLength(string inputString)
        {
            int length = 0;
            if (!string.IsNullOrEmpty(inputString))
            {
                char[] chars = inputString.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] > 127)
                    {
                        length += 2;
                    }
                    else
                    {
                        length++;
                    }
                }
            }
            return length;
        }

        #endregion
    }
}
