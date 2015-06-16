using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWebApi.Common
{
    /// <summary>
    /// 配置文件类
    /// </summary>
    public class Config
    {
        /// <summary>
        /// WCF调用参数密钥
        /// </summary>
        public static string TokenKey
        {
            get
            {
                return string.IsNullOrEmpty(ConfigurationManager.AppSettings["TokenKey"])
                    ? "DF@268vCYP"
                    : ConfigurationManager.AppSettings["TokenKey"];
            }
        }
        public static string PadPushKey
        {
            get
            {
                return string.IsNullOrEmpty(ConfigurationManager.AppSettings["PadPushKey"])
                    ? "D64379A3-41C7-4D2A-A7DB-0C9ED5A501B5"
                    : ConfigurationManager.AppSettings["PadPushKey"];
            }
        }
        public static string MobilePushKey
        {
            get
            {
                return string.IsNullOrEmpty(ConfigurationManager.AppSettings["MobilePushKey"])
                    ? "1252A7D3-7EB4-4D36-87C6-471F725105BF"
                    : ConfigurationManager.AppSettings["MobilePushKey"];
            }
        }
        //车辆图片地址
        public static string CarImageUrlSmall
        {
            get
            {
                return ConfigurationManager.AppSettings["CarImageUrlSmall"];
            }
        }
        public static string CarImageUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["CarImageUrl"];
            }
        }
    }
}
