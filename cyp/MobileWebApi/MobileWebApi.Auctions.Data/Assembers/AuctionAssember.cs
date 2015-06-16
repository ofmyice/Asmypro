using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MobileWebApi.Auctions.Domain;
using MobileWebApi.Common;

namespace MobileWebApi.Auctions.Data.Assembers
{
    public static class AuctionAssember
    {
        public static Auction SetByDataRow(this Auction auction, DataRow row)
        {
            if (row == null)
                return null;
            auction.AucId = row.RowToT<int>("AucId");
            auction.CarId = row.RowToT<int>("CarId");
            auction.CarFirstImg = row.RowToString("CarFirstImg");
            auction.Model = row.RowToString("Model");
            auction.Rank = row.RowToString("Rank");
            auction.WayTag = row.RowToT<byte>("WayTag");
            auction.TradeCode = row.RowToString("TradeCode");
            auction.EmissionStandard = row.RowToString("EmissionStandard");
            return auction;
        }

        public static IList<Auction> SetByDataTable(this IList<Auction> auctions, DataTable table)
        {
            if (table.IsNullOrEmpty())
                return auctions;
            foreach (DataRow row in table.Rows)
            {
                var auction = new Auction().SetByDataRow(row);
                if (auction != null)
                    auctions.Add(auction);
            }
            return auctions;
        }
    }
}
