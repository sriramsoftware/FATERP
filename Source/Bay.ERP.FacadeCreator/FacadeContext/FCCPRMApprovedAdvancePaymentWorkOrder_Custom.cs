// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Dec-2012, 01:43:33




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMApprovedAdvancePaymentWorkOrder_Custom
    {

        public FCCPRMApprovedAdvancePaymentWorkOrder_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMApprovedAdvancePaymentWorkOrder_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMApprovedAdvancePaymentWorkOrder_CustomFacade facade = context.Items["IPRMApprovedAdvancePaymentWorkOrder_CustomFacade"] as Bay.ERP.BusinessFacade.IPRMApprovedAdvancePaymentWorkOrder_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMApprovedAdvancePaymentWorkOrder_CustomFacade();
                context.Items["IPRMApprovedAdvancePaymentWorkOrder_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
