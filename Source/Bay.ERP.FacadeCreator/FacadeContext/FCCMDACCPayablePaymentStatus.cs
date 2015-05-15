// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Dec-2012, 08:03:28




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDACCPayablePaymentStatus
    {

        public FCCMDACCPayablePaymentStatus()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDACCPayablePaymentStatusFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDACCPayablePaymentStatusFacade facade = context.Items["IMDACCPayablePaymentStatusFacade"] as Bay.ERP.BusinessFacade.IMDACCPayablePaymentStatusFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDACCPayablePaymentStatusFacade();
                context.Items["IMDACCPayablePaymentStatusFacade"] = facade;
            }
            return facade;
        }


    }
}
