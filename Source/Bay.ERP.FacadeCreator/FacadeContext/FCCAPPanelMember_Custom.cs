// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Oct-2012, 11:49:00




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCAPPanelMember_Custom
    {

        public FCCAPPanelMember_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IAPPanelMember_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IAPPanelMember_CustomFacade facade = context.Items["IAPPanelMember_CustomFacade"] as Bay.ERP.BusinessFacade.IAPPanelMember_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.APPanelMember_CustomFacade();
                context.Items["IAPPanelMember_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
