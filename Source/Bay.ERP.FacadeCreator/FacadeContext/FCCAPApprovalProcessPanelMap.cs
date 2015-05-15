// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Jun-2013, 05:57:56




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCAPApprovalProcessPanelMap
    {

        public FCCAPApprovalProcessPanelMap()
        {

        }

        public static Bay.ERP.BusinessFacade.IAPApprovalProcessPanelMapFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IAPApprovalProcessPanelMapFacade facade = context.Items["IAPApprovalProcessPanelMapFacade"] as Bay.ERP.BusinessFacade.IAPApprovalProcessPanelMapFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.APApprovalProcessPanelMapFacade();
                context.Items["IAPApprovalProcessPanelMapFacade"] = facade;
            }
            return facade;
        }


    }
}
