using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using MobileWebApi.Special.Domain;

namespace MobileWebApi.Special.Service
{
    public interface IMyCYPService
    {
        string GetMyCYPInfo(string businessId);
    }
}
