using System.Diagnostics;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System;
using System.Linq;
using System.Linq.Expressions;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.BusinessEntities;

using System.Collections.Generic;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Shared;
using System.Security.Cryptography;
using System.Text;

namespace Bay.ERP.Web.UI.Manager
{
    public static class RNGCrypto_MachineKey
    {
        public static string getRandomKey(int bytelength)
        {
            byte[] buff = new byte[bytelength];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(buff);
            StringBuilder sb = new StringBuilder(bytelength * 2);
            for (int i = 0; i < buff.Length; i++)
                sb.Append(string.Format("{0:X2}", buff[i]));
            return sb.ToString();
        }
    }
}