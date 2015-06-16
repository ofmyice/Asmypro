using MobileWebApi.Common;

namespace MobileWebApi.User.Domain
{
    /// <summary>
    /// 资产中心首页数据
    /// </summary>
    public class CapitalIndexInfo : BasisInfo
    {
        /// <summary>
        /// 冻结保证金车辆数量
        /// </summary>
        public int FreezeCarCount { get; set; }
    }
}
