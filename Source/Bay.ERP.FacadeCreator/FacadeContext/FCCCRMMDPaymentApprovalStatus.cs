// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Apr-2013, 12:14:24




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMMDPaymentApprovalStatus
    {

        public FCCCRMMDPaymentApprovalStatus()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMMDPaymentApprovalStatusFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMMDPaymentApprovalStatusFacade facade = context.Items["ICRMMDPaymentApprovalStatusFacade"] as Bay.ERP.BusinessFacade.ICRMMDPaymentApprovalStatusFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMMDPaymentApprovalStatusFacade();
                context.Items["ICRMMDPaymentApprovalStatusFacade"] = facade;
            }
            return facade;
        }


    }
}
