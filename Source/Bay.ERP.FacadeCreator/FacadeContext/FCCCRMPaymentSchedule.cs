// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2013, 08:24:37




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMPaymentSchedule
    {

        public FCCCRMPaymentSchedule()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMPaymentScheduleFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMPaymentScheduleFacade facade = context.Items["ICRMPaymentScheduleFacade"] as Bay.ERP.BusinessFacade.ICRMPaymentScheduleFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMPaymentScheduleFacade();
                context.Items["ICRMPaymentScheduleFacade"] = facade;
            }
            return facade;
        }


    }
}
