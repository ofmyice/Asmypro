using System;
using System.Collections.Generic;

namespace MobileWebApi.Common
{
    /// <summary>
    ///     常用工具箱
    /// </summary>
    public class ToolBox
    {
        /// <summary>
        ///     逗号字符串转List集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str"></param>
        /// <returns></returns>
        public static List<T> Str2List<T>(string str)
        {
            return Str2List<T>(str, ',');
        }

        public static List<T> Str2List<T>(string str, char symbol)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
                return new List<T>();
            string[] temp = str.Split(symbol);
            var list = new List<T>();
            for (int i = 0; i < temp.Length; i++)
            {
                var _t = (T) Convert.ChangeType(temp[i], typeof (T));
                list.Add(_t);
            }
            return list;
        }

        public static int ToSaveInt(string str)
        {
            int result = 0;
            int.TryParse(str, out result);
            return result;
        }
        /// <summary>
        /// 从数组转为以逗号分隔的字符串
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static string IntArr2Str(int[] arr)
        {
            string result = string.Empty;
            if (arr.Length > 0)
            {
                result += ",";
                foreach (int item in arr)
                {
                    if (result.IndexOf("," + item.ToString() + ",") == -1)
                    {
                        result += item.ToString() + ",";
                    }
                }
                result = result.Substring(1, result.Length - 2);
            }
            return result;
        }
    }
}