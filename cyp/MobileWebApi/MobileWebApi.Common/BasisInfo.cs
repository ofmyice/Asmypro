using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWebApi.Common
{
    /// <summary>
    /// 所有返回实体对象的基类
    /// </summary>
    public class BasisInfo
    {
        public BasisInfo()
        {
            ResId = Convert.ToInt32(ResState.Fail).ToString();
        }

        public string ResId { get; set; }

        public string ResMsg
        {
            get { return this.ResId.Equals(Convert.ToInt32(ResState.Success).ToString()) ? "获取数据成功" : "获取数据失败"; }
        }

        public BasisInfo SetState(ResState state)
        {
            ResId = Convert.ToInt32(state).ToString();
            return this;
        }
    }


    public enum ResState
    {
        Success = 0,
        Fail = 1,
    }
}
