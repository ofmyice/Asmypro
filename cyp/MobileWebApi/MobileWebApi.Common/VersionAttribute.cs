using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWebApi.Common
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false,Inherited = false)]
    public class VersionAttribute : Attribute
    {
        /// <summary>
        /// 最小版本
        /// </summary>
        private string _minVersion=string.Empty;

        /// <summary>
        /// 最高版本
        /// </summary>
        private string _maxVersion = string.Empty;
        /// <summary>
        /// 指定版本
        /// </summary>
        private string _sureVersion = string.Empty;

        public VersionAttribute(string minVersion,string maxVersion)
        {
            this._maxVersion = maxVersion;
            this._minVersion = minVersion;
        }

        public VersionAttribute(string sureVersion)
        {
            this._sureVersion = sureVersion;
        }
        /// <summary>
        /// 最小版本号
        /// </summary>
        public string MinVersion {
            get { return this._minVersion; }
        }
        /// <summary>
        /// 最大版本号
        /// </summary>
        public string MaxVersion {
            get { return this._maxVersion; }
        }
        /// <summary>
        /// 指定版本号
        /// </summary>
        public string SureVersion {
            get { return this._sureVersion; }
        }
    }
}
