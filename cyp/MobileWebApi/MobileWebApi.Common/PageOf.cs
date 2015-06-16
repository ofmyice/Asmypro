using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWebApi.Common
{
    /// <summary>
    /// 分页返回类型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PageOf<T>
    {
        /// <summary>
        /// 总数
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 列表
        /// </summary>
        public IList<T> Items { get; set; }
    }
}
