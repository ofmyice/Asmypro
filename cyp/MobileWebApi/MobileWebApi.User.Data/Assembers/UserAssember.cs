using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileWebApi.Common;
using MobileWebApi.User.Domain.DataModel;

namespace MobileWebApi.User.Data.Assembers
{
    public static class UserAssember
    {
        public static IList<UserRight> SetByDataTable(this IList<UserRight> userRights, DataTable dataTable)
        {
            if (dataTable.IsNullOrEmpty())
                return userRights;
            foreach (DataRow row in dataTable.Rows)
            {
                var auction = new UserRight().SetByDataRow(row);
                if (auction != null)
                    userRights.Add(auction);
            }
            return userRights;
        }

        public static UserRight SetByDataRow(this UserRight userRight, DataRow row)
        {
            if (row == null) return null;
            userRight.Orid = row.RowToT<Int16>("Orid");
            userRight.ModeTag = row.RowToT<byte>("ModeTag");
            userRight.OperTag = row.RowToT<byte>("OperTag");
            userRight.OrName = row.RowToString("OrName");
            return userRight;
        }
    }
}
