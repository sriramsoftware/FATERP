// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-May-2013, 01:09:58




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMDuePaymentFromPaymentSchedule_RPT
    {

        public FCCCRMDuePaymentFromPaymentSchedule_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMDuePaymentFromPaymentSchedule_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMDuePaymentFromPaymentSchedule_RPTFacade facade = context.Items["ICRMDuePaymentFromPaymentSchedule_RPTFacade"] as Bay.ERP.BusinessFacade.ICRMDuePaymentFromPaymentSchedule_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMDuePaymentFromPaymentSchedule_RPTFacade();
                context.Items["ICRMDuePaymentFromPaymentSchedule_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
