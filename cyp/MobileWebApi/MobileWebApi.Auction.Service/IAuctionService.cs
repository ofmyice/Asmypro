using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobileWebApi.Auction.Domain;

namespace MobileWebApi.Auction.Service
{
    public interface IAuctionService
    {
        List<HotCars> GetHotCarses();
    }
}
