using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using MobileWebApi.Auctions.Domain;
using MobileWebApi.Auctions.Domain.IRepositories;

namespace MobileWebApi.Auctions.Service.Impl
{
    public class AuctionService:IAuctionService
    {
        private readonly IReadOnlyAuctionRepository _readOnlyAuctionRepo;

        public AuctionService(IReadOnlyAuctionRepository readOnlyAuctionRepository)
        {
            _readOnlyAuctionRepo = readOnlyAuctionRepository;
        }
        /// <summary>
        /// 获取热销车辆
        /// </summary>
        /// <param name="top"></param>
        /// <returns></returns>
        public IList<Auction> GetHotCars(int top, int aucType)
        {
            var result = _readOnlyAuctionRepo.GetHotCars(top, aucType);
            return result;
        }
        /// <summary>
        /// 获取待确认车辆
        /// </summary>
        /// <param name="businessId"></param>
        /// <param name="aucRootTag"0:全部,1:活动车></param>
        /// <param name="searchTxt"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        public UnConfirmCars GetUnConfirmCarList(int businessId, int aucRootTag, string searchTxt, int pageSize,
            int pageIndex)
        {
            //var dataList = "调服务";
            UnConfirmCars result = new UnConfirmCars();
            //result.Data = dataList.Data;
            //result.TotalCount = "dataList.TotalCount";
            return new UnConfirmCars();
        }
    }
}
