using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using MobileWebApi.Misc.Data.Assembers;
using MobileWebApi.Misc.Domain;
using System.Data;
using MobileWebApi.Common.DbHelpers;
using MobileWebApi.Common;
using MobileWebApi.Misc.Domain.IRepositories;
using Microsoft.ApplicationBlocks.Data;
namespace MobileWebApi.Misc.Data
{
    public class ReadOnlyMessageRepository : ReadOnlyBaseRepository,IReadOnlyMessageRepository
    {
        public PageOf<Message> GetMessageList(int businessId, int pageIndex, int pageSize)
        {
            var sql = @"SELECT UserID,AucID,CarID,MsgType,MsgContentBig,ShowTagBig,MsgContentSmall,ShowTagSmall,CreateDate,ROW_NUMBER() OVER(ORDER BY CreateDate DESC) AS RowNo INTO #messageList
                        FROM T_SHD_PushMessage  WHERE DeleteTag=0 AND MsgType<>14 AND UserID=@businessId
                        SELECT * FROM #messageList WHERE RowNo BETWEEN (@pageIndex-1)*@PageSize+1 AND @pageIndex*@PageSize
                        SELECT COUNT(*) AS TotalCount FROM #messageList
                        DROP TABLE #messageList";
            var parameters = new[] { new SqlParameter("@businessId", businessId), new SqlParameter("@pageIndex",pageIndex),new SqlParameter("@pageSize",pageSize) };
            var ds = SqlHelper.ExecuteDataset(ReadOnlyDBSYSConn, CommandType.Text, sql, parameters);
            if (ds.IsNullOrEmpty())
                return new PageOf<Message> {TotalCount = 0, Items = new List<Message>()};
            var items = new List<Message>().SetByDataTable(ds.Tables[0]);
            var Total = ds.Tables[1].Rows[0].RowToT<int>("TotalCount");
            return new PageOf<Message>
            {
                TotalCount = Total,
                Items = items
            };
        }

        public Message GetMessageById(int id)
        {
            var sql = @"SELECT UserID,AucID,CarID,MsgType,MsgContentBig,ShowTagBig,MsgContentSmall,ShowTagSmall,CreateDate FROM T_SHD_PushMessage  WHERE ID=@Id";
            var parameters = new[] { new SqlParameter("@Id", id) };
            var ds = SqlHelper.ExecuteDataset(ReadOnlyDBSYSConn, CommandType.Text, sql, parameters);
            if (ds.IsNullOrEmpty())
                return new Message();
            var items = new Message().SetByDataRow(ds.Tables[0].Rows[0]);
            return items;
        }
        public PageOf<Message> GetNoticeList(int pageIndex, int pageSize)
        {
            var sql = @"SELECT ID,MsgContentBig,ShowTagBig,MsgContentSmall,ShowTagSmall,CreateDate，ROW_NUMBER() OVER(ORDER BY CreateDate DESC) AS RowNo INTO #noticeList
                        FROM T_SHD_PushMessage  WHERE DeleteTag=0 AND MsgType=14 
                        SELECT * FROM #noticeList WHERE RowNo BETWEEN (@pageIndex-1)*@PageSize+1 AND @pageIndex*@PageSize
                        SELECT COUNT(*) AS TotalCount FROM #noticeList
                        DROP TABLE #noticeList";
            var parameters = new[] {new SqlParameter("@pageIndex", pageIndex), new SqlParameter("@pageSize", pageSize) };
            var ds = SqlHelper.ExecuteDataset(ReadOnlyDBSYSConn, CommandType.Text, sql, parameters);
            if (ds.IsNullOrEmpty())
                return new PageOf<Message> { TotalCount = 0, Items = new List<Message>() };
            var items = new List<Message>().SetByDataTable(ds.Tables[0]);
            var Total = ds.Tables[1].Rows[0].RowToT<int>("TotalCount");
            return new PageOf<Message>
            {
                TotalCount = Total,
                Items = items
            };
        }
        /// <summary>
        /// 获取未读消息数量
        /// </summary>
        /// <param name="businessId"></param>
        /// <param name="showTagType"></param>
        /// <param name="readType"></param>
        /// <param name="msgType"></param>
        /// <returns></returns>
        public int GetMsgStateCount(int businessId, int showTagType, int readType, int msgType)
        {
            int count = 0;
            var sql = @"SELECT COUNT(*) FROM T_SHD_PushMessage  WHERE 1=1{0}{1}{2}";
            string userCondition = string.Empty;
            string tagCondition = string.Empty;//0:大消息，1：小消息
            string msgTypeCondition = string.Empty;
            if (businessId > 0)
            {
                userCondition = " AND UserID=@uId ";
            }
            if (showTagType == 0)
            {
                tagCondition = " AND ShowTagBig=@redaType";
            }
            else
            {
                tagCondition = " AND ShowTagSmall=@redaType";
            }
            if (msgType == 14)
            {
                msgTypeCondition = " AND MsgType=14";
            }
            else
            {
                msgTypeCondition = " AND MsgType<>14";
            }
            var parameters = new[] { new SqlParameter("@uId", businessId), new SqlParameter("@redaType",readType) };
            count = (int)SqlHelper.ExecuteScalar(ReadOnlyDBSYSConn, CommandType.Text, string.Format(sql, userCondition, tagCondition, msgTypeCondition), parameters);
            return count;
        }

        /// <summary>
        /// 更新消息读的状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="showTagType"></param>
        public int SetTagState(int id, int showTagType, int readState)// showTagType=0:大消息,1:小消息,readState=0未读，1已读
        {
            string sql = string.Empty;
            if (showTagType == 0)
            {
                sql = @"UPDATE T_SHD_PushMessage SET ShowTagBig=@readState WHERE ID=@id";
            }
            else
            {
                sql = @"UPDATE T_SHD_PushMessage SET ShowTagSmall=@readState WHERE ID=@id";
            }
            var parameters = new[] { new SqlParameter("@Id", id), new SqlParameter("@readState",readState) };
            return SqlHelper.ExecuteNonQuery(ReadOnlyDBSYSConn, CommandType.Text, sql, parameters);
        }
    }
}
