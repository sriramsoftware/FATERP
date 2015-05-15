// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Mar-2012, 12:28:08




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMNDashboardItemQuicklink_Detailed
    {

        public FCCCMNDashboardItemQuicklink_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMNDashboardItemQuicklink_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMNDashboardItemQuicklink_DetailedFacade facade = context.Items["ICMNDashboardItemQuicklink_DetailedFacade"] as Bay.ERP.BusinessFacade.ICMNDashboardItemQuicklink_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMNDashboardItemQuicklink_DetailedFacade();
                context.Items["ICMNDashboardItemQuicklink_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
