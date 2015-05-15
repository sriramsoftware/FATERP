// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Feb-2012, 06:02:47




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMNDashboardItem
    {

        public FCCCMNDashboardItem()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMNDashboardItemFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMNDashboardItemFacade facade = context.Items["ICMNDashboardItemFacade"] as Bay.ERP.BusinessFacade.ICMNDashboardItemFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMNDashboardItemFacade();
                context.Items["ICMNDashboardItemFacade"] = facade;
            }
            return facade;
        }


    }
}
