// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Jul-2013, 11:47:45




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACBankAccountDepositItem_Detailed
    {

        public FCCACBankAccountDepositItem_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IACBankAccountDepositItem_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACBankAccountDepositItem_DetailedFacade facade = context.Items["IACBankAccountDepositItem_DetailedFacade"] as Bay.ERP.BusinessFacade.IACBankAccountDepositItem_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACBankAccountDepositItem_DetailedFacade();
                context.Items["IACBankAccountDepositItem_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
