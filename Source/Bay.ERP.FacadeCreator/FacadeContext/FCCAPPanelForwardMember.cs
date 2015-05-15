// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Oct-2012, 11:32:20




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCAPPanelForwardMember
    {

        public FCCAPPanelForwardMember()
        {

        }

        public static Bay.ERP.BusinessFacade.IAPPanelForwardMemberFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IAPPanelForwardMemberFacade facade = context.Items["IAPPanelForwardMemberFacade"] as Bay.ERP.BusinessFacade.IAPPanelForwardMemberFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.APPanelForwardMemberFacade();
                context.Items["IAPPanelForwardMemberFacade"] = facade;
            }
            return facade;
        }


    }
}
