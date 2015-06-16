using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobileWebApi.Auction.Domain;
using MobileWebApi.Auction.Domain.IRepositories;

namespace MobileWebApi.Auction.Service.Impl
{
    public class AuctionService:IAuctionService
    {
        private readonly IReadOnlyAuctionRepository _readOnlyAuctionRepo;

        public AuctionService(IReadOnlyAuctionRepository readOnlyAuctionRepository)
        {
            _readOnlyAuctionRepo = readOnlyAuctionRepository;
        }

        public List<HotCars> GetHotCarses()
        {
            
            return new List<HotCars>();
        }
    }
}
