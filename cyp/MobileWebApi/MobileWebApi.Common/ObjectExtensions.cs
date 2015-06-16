using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace MobileWebApi.Common
{
    public static class ObjectExtensions
    {
        /// <summary>
        /// 获取DataRow字段值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="row"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static T RowToT<T>(this DataRow row, string columnName)
        {
            try
            {
                return !row.Table.Columns.Contains(columnName) || row.IsNull(columnName)
                    ? default(T)
                    : row.Field<T>(columnName);
            }
            catch
            {
                return default(T);
            }
        }

        /// <summary>
        /// 获取DataRow字段值并转换成string类型
        /// </summary>
        /// <param name="row"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static string RowToString(this DataRow row, string columnName)
        {
            try
            {
                var str = row.RowToT<String>(columnName);
                return str.SafeToString();
            }
            catch
            {
                return string.Empty;
            }
        }


        /// <summary>
        /// 更加安全的调用对象的ToString方法，如果是null，返回string.Empty；其它情况调用实际的ToString。
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SafeToString(this object value)
        {
            return value == null ? string.Empty : value.ToString();
        }

        public static bool IsNullOrEmpty(this DataSet dataSet)
        {
            if (dataSet == null || dataSet.Tables.Count == 0 || dataSet.Tables[0].Rows.Count == 0)
                return true;
            return false;
        }

        public static bool IsNullOrEmpty(this DataTable table)
        {
            if (table == null || table.Rows.Count == 0)
                return true;
            return false;
        }



        public static IList<int> ToIntList(this string str)
        {
            return str.ToIntList(',');
        }

        public static IList<int> ToIntList(this string str, char separator)
        {
            if (string.IsNullOrEmpty(str))
                return new List<int>();
            var sp = str.Split(separator);
            var result = new List<int>();
            foreach (var s in sp)
            {
                var id = 0;
                if (int.TryParse(s, out id))
                    result.Add(id);
            }
            return result;
        }

        public static string PriceToCapital(string money)
        {
            //将小写金额转换成大写金额           
            var myNumber = Convert.ToDouble(money);
            String[] myScale =
            {
                "分", "角", "元", "拾", "佰", "仟", "万", "拾", "佰", "仟", "亿", "拾", "佰", "仟", "兆", "拾", "佰", "仟"
            };
            String[] myBase = { "零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖" };
            var m = "";
            bool isPoint = false;
            if (money.IndexOf(".", StringComparison.Ordinal) != -1)
            {
                money = money.Remove(money.IndexOf(".", StringComparison.Ordinal), 1);
                isPoint = true;
            }
            for (var i = money.Length; i > 0; i--)
            {
                int myData = Convert.ToInt16(money[money.Length - i].ToString());
                m += myBase[myData];
                if (isPoint)
                {
                    m += myScale[i - 1];
                }
                else
                {
                    m += myScale[i + 1];
                }
            }
            return m;
        }

        public static string DaXie(string money)
        {
            var s = double.Parse(money).ToString("#L#E#D#C#K#E#D#C#J#E#D#C#I#E#D#C#H#E#D#C#G#E#D#C#F#E#D#C#.0B0A");
            var d = Regex.Replace(s,
                @"((?<=-|^)[^1-9]*)|((?'z'0)[0A-E]*((?=[1-9])|(?'-z'(?=[F-L\.]|$))))|((?'b'[F-L])(?'z'0)[0A-L]*((?=[1-9])|(?'-z'(?=[\.]|$))))",
                "${b}${z}");
            return Regex.Replace(d, ".",
                m => "负元空零壹贰叁肆伍陆柒捌玖空空空空空空空分角拾佰仟万億兆京垓秭穰"[m.Value[0] - '-'].ToString());
        }

        /// <summary> 
        /// 对象转JSON 
        /// </summary> 
        /// <param name="obj">对象</param> 
        /// <returns>JSON格式的字符串</returns> 
        public static string ObjectToJSON(object obj)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            try
            {
                return jss.Serialize(obj);
            }
            catch (Exception ex)
            {
                throw new Exception("JSONHelper.ObjectToJSON(): " + ex.Message);
            }
        }

        /// <summary>
        /// 判断可空类型是否为空，或者是否为默认值
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="value">传入的可空类型的对象</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>true：为空或为默认值；false：不为空且不为默认值</returns>
        public static bool IsNullOrDefault<T>(this object value, T defaultValue = default(T))
        {
            var cValue = (value == null) ? defaultValue : Convert.ChangeType(value, typeof(T));
            return cValue.Equals(defaultValue);
        }
    }
}
