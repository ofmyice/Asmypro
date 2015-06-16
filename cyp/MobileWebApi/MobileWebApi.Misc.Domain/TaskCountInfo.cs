using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWebApi.Common;

namespace MobileWebApi.Misc.Domain
{
    public class TaskCountInfo:BasisInfo
    {
        /// <summary>
        /// 总任务数
        /// </summary>
        public int TaskCount { get; set; }
        /// <summary>
        /// 已完成的任务数量
        /// </summary>
        public int CompleteCount { get; set; }
        /// <summary>
        /// 总代金币数量
        /// </summary>
        public int RewordCount { get; set; }
        /// <summary>
        /// 已经获取的代金币数量
        /// </summary>
        public int CompleteReword { get; set; }
    }
}
