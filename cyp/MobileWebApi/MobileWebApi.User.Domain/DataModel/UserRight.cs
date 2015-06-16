using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWebApi.User.Domain.DataModel
{
    /// <summary>
    /// 用户权限信息
    /// </summary>
    public class UserRight
    {
        public int Orid { get; set; }
        public int ModeTag { get; set; }
        public int OperTag { get; set; }
        public string OrName { get; set; }
    }
}
