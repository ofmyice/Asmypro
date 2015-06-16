using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MobileWebApi.Misc.Service
{
    public interface IMyCYPService
    {
        string GetMyCYPInfo(int businessId);
        string SaveHeadImg(string businessId,HttpPostedFileBase logo);
    }
}
