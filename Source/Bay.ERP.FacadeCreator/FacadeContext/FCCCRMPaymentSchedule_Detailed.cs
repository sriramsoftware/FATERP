// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Dec-2013, 10:37:38




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMPaymentSchedule_Detailed
    {

        public FCCCRMPaymentSchedule_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMPaymentSchedule_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMPaymentSchedule_DetailedFacade facade = context.Items["ICRMPaymentSchedule_DetailedFacade"] as Bay.ERP.BusinessFacade.ICRMPaymentSchedule_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMPaymentSchedule_DetailedFacade();
                context.Items["ICRMPaymentSchedule_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
