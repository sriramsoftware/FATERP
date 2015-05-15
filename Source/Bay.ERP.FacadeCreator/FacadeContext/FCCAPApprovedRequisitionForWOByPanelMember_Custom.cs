// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Jan-2013, 11:24:12




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCAPApprovedRequisitionForWOByPanelMember_Custom
    {

        public FCCAPApprovedRequisitionForWOByPanelMember_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IAPApprovedRequisitionForWOByPanelMember_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IAPApprovedRequisitionForWOByPanelMember_CustomFacade facade = context.Items["IAPApprovedRequisitionForWOByPanelMember_CustomFacade"] as Bay.ERP.BusinessFacade.IAPApprovedRequisitionForWOByPanelMember_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.APApprovedRequisitionForWOByPanelMember_CustomFacade();
                context.Items["IAPApprovedRequisitionForWOByPanelMember_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
