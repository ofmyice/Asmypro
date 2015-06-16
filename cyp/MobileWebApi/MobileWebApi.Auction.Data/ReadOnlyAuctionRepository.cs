using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using MobileWebApi.Auction.Domain;
using MobileWebApi.Auction.Domain.IRepositories;
using Microsoft.ApplicationBlocks.Data;
using MobileWebApi.Common.DbHelpers;

namespace MobileWebApi.Auction.Data
{
    public class ReadOnlyAuctionRepository : ReadOnlyBaseRepository,IReadOnlyAuctionRepository
    {
        public List<HotCars> GetHotCarses()
        {
            var sql = @"";
            var ds = SqlHelper.ExecuteDataset(ReadOnlyConn, CommandType.Text,sql);
            return new List<HotCars>();
        }
    }
}
