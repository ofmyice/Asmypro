using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWebApi.Auctions.Domain.IRepositories
{
    public interface IReadOnlyAuctionRepository
    {
        IList<Auction> GetHotCars(int top,int aucType);
    }
}
