using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWebApi.Common
{
    /// <summary>
    /// 返回数据列表的Json对象基类
    /// </summary>
   public class ListBasisInfo:BasisInfo
    {
        public object Data { get; set; }
        public int TotalCount { get; set; }
    }
}
