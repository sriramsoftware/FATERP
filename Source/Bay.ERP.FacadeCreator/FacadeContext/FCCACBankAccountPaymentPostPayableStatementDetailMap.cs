// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jun-2013, 02:26:08




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACBankAccountPaymentPostPayableStatementDetailMap
    {

        public FCCACBankAccountPaymentPostPayableStatementDetailMap()
        {

        }

        public static Bay.ERP.BusinessFacade.IACBankAccountPaymentPostPayableStatementDetailMapFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACBankAccountPaymentPostPayableStatementDetailMapFacade facade = context.Items["IACBankAccountPaymentPostPayableStatementDetailMapFacade"] as Bay.ERP.BusinessFacade.IACBankAccountPaymentPostPayableStatementDetailMapFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACBankAccountPaymentPostPayableStatementDetailMapFacade();
                context.Items["IACBankAccountPaymentPostPayableStatementDetailMapFacade"] = facade;
            }
            return facade;
        }


    }
}
