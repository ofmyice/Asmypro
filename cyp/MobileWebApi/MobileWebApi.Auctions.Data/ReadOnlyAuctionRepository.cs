using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationBlocks.Data;
using MobileWebApi.Auctions.Data.Assembers;
using MobileWebApi.Auctions.Domain.IRepositories;
using MobileWebApi.Common.DbHelpers;
using MobileWebApi.Common;
using MobileWebApi.Auctions.Domain;
namespace MobileWebApi.Auctions.Data
{
    public class ReadOnlyAuctionRepository : ReadOnlyBaseRepository, IReadOnlyAuctionRepository
    {
        public IList<Auction> GetHotCars(int top,int aucType)
        {
            string aucTypeCondition = string.Empty;
            if (aucType == 1)//快拍约束
            {
                aucTypeCondition = @" AND a.AucRootTag<4";
            }
            else if (aucType == 2)//易拍约束
            {
                aucTypeCondition = @" AND a.AucRootTag=4";                
            }
            else if (aucType == 0)
            {
                aucTypeCondition = @" AND a.AucRootTag<5";   
            }
            var sql = @"DECLARE @NOW DATETIME
                        SET @NOW=GETDATE();
                        SELECT TOP (@Top) a.AucId,a.CarId,c.CarFirstImg,c.Model,ISNULL(WayTag,1) WayTag,c.TradeCode,
                        ( CASE WHEN LEN(C.[RankDesc]) >= 3 THEN C.[RankDesc] ELSE CONVERT(VARCHAR, CONVERT(INT, C.RankLevel))+ISNULL(C.[RankDesc], '') END ) AS [Rank],
                        CASE ISNULL(c.EmissionStandard,0) WHEN 10 THEN '国二及以下' WHEN 20 THEN '国二及以下' WHEN 30 THEN '国三' WHEN 40 THEN '国四' WHEN 50 THEN '国五' WHEN 0 THEN '不详' ELSE '' END AS  EmissionStandard
                        FROM dbo.tbAuction_BaseInfo_Temp a(NOLOCK)
                        INNER JOIN T_TRA_Car c(NOLOCK) ON a.CarId=c.CarId
                        INNER JOIN tbOrganize_Root R(NOLOCK) ON R.Id=a.RootId
                        WHERE c.deletetag=0 AND a.DeleteTag=0 AND a.BeginTime<=@Now AND EndTime>@Now AND R.CompanyId=1  {0}
                        ORDER BY a.TotalBidCount DESC ";
            var parameters = new[] { new SqlParameter("@Top", top)};
            var ds = SqlHelper.ExecuteDataset(ReadOnlyConn, CommandType.Text, string.Format(sql, aucTypeCondition), parameters);
            if (ds.IsNullOrEmpty())
                return new List<Auction>();
            var items = new List<Auction>().SetByDataTable(ds.Tables[0]);
            return items;
        }
    }
}
