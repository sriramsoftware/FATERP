// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Mar-2012, 11:45:48




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMNDashboardItemQuicklink
    {

        public FCCCMNDashboardItemQuicklink()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMNDashboardItemQuicklinkFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMNDashboardItemQuicklinkFacade facade = context.Items["ICMNDashboardItemQuicklinkFacade"] as Bay.ERP.BusinessFacade.ICMNDashboardItemQuicklinkFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMNDashboardItemQuicklinkFacade();
                context.Items["ICMNDashboardItemQuicklinkFacade"] = facade;
            }
            return facade;
        }


    }
}
