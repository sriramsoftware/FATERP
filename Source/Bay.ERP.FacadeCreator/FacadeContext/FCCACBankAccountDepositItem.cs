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
    public class FCCACBankAccountDepositItem
    {

        public FCCACBankAccountDepositItem()
        {

        }

        public static Bay.ERP.BusinessFacade.IACBankAccountDepositItemFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACBankAccountDepositItemFacade facade = context.Items["IACBankAccountDepositItemFacade"] as Bay.ERP.BusinessFacade.IACBankAccountDepositItemFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACBankAccountDepositItemFacade();
                context.Items["IACBankAccountDepositItemFacade"] = facade;
            }
            return facade;
        }


    }
}
