using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileWebApi.Common.DbHelpers
{
    public class ReadOnlyBaseRepository
    {
        protected internal string ReadOnlyConn = System.Configuration.ConfigurationManager.ConnectionStrings["ReadOnlyConn"].ToString();
        protected internal string ReadOnlyDBSYSConn = System.Configuration.ConfigurationManager.ConnectionStrings["ReadOnlyDBSYSConn"].ToString();
    }
}
