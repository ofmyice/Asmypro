using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWebApi.User.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class Voucher
    {
        /// <summary>
        /// 代金币种类
        /// 0通用特约 19上海特约 76南京特约 80广州特约 100普通平台
        /// </summary>
        public int Orid { get; set; }
        /// <summary>
        /// 剩余总额
        /// </summary>
        public int TotalSum { get; set; }
        /// <summary>
        /// 是否显示
        /// </summary>
        public int IsShow { get; set; }
        /// <summary>
        /// 收入总额
        /// </summary>
        public int InSum { get; set; }
        /// <summary>
        /// 支出总额
        /// </summary>
        public int OutSum { get; set; }
        /// <summary>
        /// 使用上限
        /// </summary>
        public int LimitMax { get; set; }
        /// <summary>
        /// 使用下限
        /// </summary>
        public int LimitMin { get; set; }
        /// <summary>
        /// 属性 0平台代金币 1通用特约代金币 2区域特约代金币 
        /// </summary>
        public int Limt { get; set; }
        /// <summary>
        /// 使用界面提示
        /// </summary>
        public string Tip { get; set; }
    }
}
