// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Dec-2013, 03:44:05




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMPaymentSchedule_RPT
    {

        public FCCCRMPaymentSchedule_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMPaymentSchedule_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMPaymentSchedule_RPTFacade facade = context.Items["ICRMPaymentSchedule_RPTFacade"] as Bay.ERP.BusinessFacade.ICRMPaymentSchedule_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMPaymentSchedule_RPTFacade();
                context.Items["ICRMPaymentSchedule_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
