// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Oct-2012, 05:05:46




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCAPForwardInfo_Detailed
    {

        public FCCAPForwardInfo_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IAPForwardInfo_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IAPForwardInfo_DetailedFacade facade = context.Items["IAPForwardInfo_DetailedFacade"] as Bay.ERP.BusinessFacade.IAPForwardInfo_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.APForwardInfo_DetailedFacade();
                context.Items["IAPForwardInfo_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
