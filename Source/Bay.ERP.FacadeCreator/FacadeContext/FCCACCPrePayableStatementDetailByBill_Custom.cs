// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Dec-2012, 04:37:54




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACCPrePayableStatementDetailByBill_Custom
    {

        public FCCACCPrePayableStatementDetailByBill_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IACCPrePayableStatementDetailByBill_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACCPrePayableStatementDetailByBill_CustomFacade facade = context.Items["IACCPrePayableStatementDetailByBill_CustomFacade"] as Bay.ERP.BusinessFacade.IACCPrePayableStatementDetailByBill_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACCPrePayableStatementDetailByBill_CustomFacade();
                context.Items["IACCPrePayableStatementDetailByBill_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
