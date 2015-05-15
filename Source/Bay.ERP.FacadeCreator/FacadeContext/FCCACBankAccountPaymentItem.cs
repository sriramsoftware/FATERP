// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Jul-2013, 11:20:53




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACBankAccountPaymentItem
    {

        public FCCACBankAccountPaymentItem()
        {

        }

        public static Bay.ERP.BusinessFacade.IACBankAccountPaymentItemFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACBankAccountPaymentItemFacade facade = context.Items["IACBankAccountPaymentItemFacade"] as Bay.ERP.BusinessFacade.IACBankAccountPaymentItemFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACBankAccountPaymentItemFacade();
                context.Items["IACBankAccountPaymentItemFacade"] = facade;
            }
            return facade;
        }


    }
}
