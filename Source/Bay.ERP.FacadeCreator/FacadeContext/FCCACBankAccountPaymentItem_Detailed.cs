// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 12:29:09




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACBankAccountPaymentItem_Detailed
    {

        public FCCACBankAccountPaymentItem_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IACBankAccountPaymentItem_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACBankAccountPaymentItem_DetailedFacade facade = context.Items["IACBankAccountPaymentItem_DetailedFacade"] as Bay.ERP.BusinessFacade.IACBankAccountPaymentItem_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACBankAccountPaymentItem_DetailedFacade();
                context.Items["IACBankAccountPaymentItem_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
