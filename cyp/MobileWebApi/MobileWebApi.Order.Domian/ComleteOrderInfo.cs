using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWebApi.Common;

namespace MobileWebApi.Order.Domian
{
    /// <summary>
    /// 已成交列表Json实体
    /// </summary>
    public class ComleteOrderInfo:BasisInfo
    {
        public object Data { get; set; }
        public string TotalCount { get; set; }
    }
}
