// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Feb-2012, 12:56:26




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMNDashboardItem_Detailed
    {

        public FCCCMNDashboardItem_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMNDashboardItem_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMNDashboardItem_DetailedFacade facade = context.Items["ICMNDashboardItem_DetailedFacade"] as Bay.ERP.BusinessFacade.ICMNDashboardItem_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMNDashboardItem_DetailedFacade();
                context.Items["ICMNDashboardItem_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
