// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Jan-2014, 04:17:08




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHRMonthlySalaryPayment_Custom
    {

        public FCCHRMonthlySalaryPayment_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IHRMonthlySalaryPayment_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHRMonthlySalaryPayment_CustomFacade facade = context.Items["IHRMonthlySalaryPayment_CustomFacade"] as Bay.ERP.BusinessFacade.IHRMonthlySalaryPayment_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HRMonthlySalaryPayment_CustomFacade();
                context.Items["IHRMonthlySalaryPayment_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
