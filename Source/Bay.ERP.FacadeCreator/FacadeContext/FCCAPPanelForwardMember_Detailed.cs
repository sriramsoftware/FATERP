// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Oct-2012, 06:49:23




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCAPPanelForwardMember_Detailed
    {

        public FCCAPPanelForwardMember_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IAPPanelForwardMember_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IAPPanelForwardMember_DetailedFacade facade = context.Items["IAPPanelForwardMember_DetailedFacade"] as Bay.ERP.BusinessFacade.IAPPanelForwardMember_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.APPanelForwardMember_DetailedFacade();
                context.Items["IAPPanelForwardMember_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
