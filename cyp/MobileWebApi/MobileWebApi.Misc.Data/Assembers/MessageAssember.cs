using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MobileWebApi.Common;
using MobileWebApi.Misc.Domain;

namespace MobileWebApi.Misc.Data.Assembers
{
    public static class MessageAssember
    {
        public static Message SetByDataRow(this Message msg, DataRow row)
        {
            if (row == null)
                return null;
            msg.AucId = row.RowToT<int>("AucId");
            msg.CarId = row.RowToT<int>("CarId");
            msg.MessageType = row.RowToT<int>("MsgType");
            msg.CreateDate = row.RowToT<DateTime>("CreateDate").ToString();
            msg.MsgContentBig = row.RowToString("MsgContentBig");
            msg.MsgContentSmall = row.RowToString("MsgContentSmall");
            msg.ShowTagBig = row.RowToT<int>("ShowTagBig");
            msg.ShowTagSmall = row.RowToT<int>("ShowTagSmall");
            return msg;
        }

        public static IList<Message> SetByDataTable(this IList<Message> msgList, DataTable table)
        {
            if (table.IsNullOrEmpty())
                return msgList;
            foreach (DataRow row in table.Rows)
            {
                var msg = new Message().SetByDataRow(row);
                if (msg != null)
                    msgList.Add(msg);
            }
            return msgList;
        }
    }
}
