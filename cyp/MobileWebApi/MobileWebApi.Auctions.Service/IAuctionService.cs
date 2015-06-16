using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobileWebApi.Auctions.Domain;

namespace MobileWebApi.Auctions.Service
{
    public interface IAuctionService
    {
        /// <summary>
        /// 获取热销车辆
        /// </summary>
        /// <param name="top"></param>
        /// <returns></returns>
        IList<Auction> GetHotCars(int top, int aucType);

        UnConfirmCars GetUnConfirmCarList(int businessId, int aucRootTag, string searchTxt, int pageSize, int pageIndex);
    }
}
