using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWebApi.Common;

namespace MobileWebApi.User.Domain
{
    public class LoginResultInfo:BasisInfo
    {
        /// <summary>
        /// 登录提示
        /// </summary>
        public string Tip { get; set; }
        /// <summary>
        /// 登录状态
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 加密后的用户id
        /// </summary>
        public string BusinessId { get; set; }
        /// <summary>
        /// 未加密的用户ID
        /// </summary>
        public int BusID { get; set; }
        /// <summary>
        /// 用户域ID
        /// </summary>
        public int Orid { get; set; }
        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户公司名称
        /// </summary>
        public string UserCompanyName { get; set; }
       /// <summary>
       /// 在线ID
       /// </summary>
        public string Onlineid { get; set; }
        /// <summary>
        /// VIP等级
        /// </summary>
        public int VipLevel { get; set; }
        /// <summary>
        /// 是否观摩商户
        /// </summary>
        public int DemonstrateTag { get; set; }
        /// <summary>
        /// 是否手机可以出价
        /// </summary>
        public int MobileTag { get; set; }
        /// <summary>
        /// 用户权限
        /// </summary>
        public object UserRight { get; set; }
        /// <summary>
        /// 用户权限域ID
        /// </summary>
        public string AllOrid { get; set; }
        /// <summary>
        /// 用户类型
        /// </summary>
        public int UserType { get; set; }
        /// <summary>
        /// 是否商信通
        /// </summary>
        public bool IsSxt { get; set; }
        /// <summary>
        /// 是否同意注册协议0未同意 1 同意
        /// </summary>
        public int IsAgree { get; set; }
    }
}
