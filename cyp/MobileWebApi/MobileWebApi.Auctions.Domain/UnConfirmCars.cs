using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWebApi.Common;

namespace MobileWebApi.Auctions.Domain
{
    public class UnConfirmCars : BasisInfo
    {
        public int TotalCount { get; set; }
        public object Data { get; set; }
    }
}
