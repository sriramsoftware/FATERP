// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Feb-2013, 12:00:20




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACMDBankAccountPaymentApprovalStatus
    {

        public FCCACMDBankAccountPaymentApprovalStatus()
        {

        }

        public static Bay.ERP.BusinessFacade.IACMDBankAccountPaymentApprovalStatusFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACMDBankAccountPaymentApprovalStatusFacade facade = context.Items["IACMDBankAccountPaymentApprovalStatusFacade"] as Bay.ERP.BusinessFacade.IACMDBankAccountPaymentApprovalStatusFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACMDBankAccountPaymentApprovalStatusFacade();
                context.Items["IACMDBankAccountPaymentApprovalStatusFacade"] = facade;
            }
            return facade;
        }


    }
}
