// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDEmployeeSalaryPaymentStatus
    {

        public FCCMDEmployeeSalaryPaymentStatus()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDEmployeeSalaryPaymentStatusFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDEmployeeSalaryPaymentStatusFacade facade = context.Items["IMDEmployeeSalaryPaymentStatusFacade"] as Bay.ERP.BusinessFacade.IMDEmployeeSalaryPaymentStatusFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDEmployeeSalaryPaymentStatusFacade();
                context.Items["IMDEmployeeSalaryPaymentStatusFacade"] = facade;
            }
            return facade;
        }


    }
}
