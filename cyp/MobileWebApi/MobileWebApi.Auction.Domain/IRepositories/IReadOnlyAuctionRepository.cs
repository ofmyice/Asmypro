using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobileWebApi.Auction.Domain.IRepositories
{
    public interface IReadOnlyAuctionRepository
    {
        List<HotCars> GetHotCarses();
    }
}
