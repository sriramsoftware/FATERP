// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jul-2013, 11:50:30




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACBankAccountDeposit_Detailed
    {

        public FCCACBankAccountDeposit_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IACBankAccountDeposit_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACBankAccountDeposit_DetailedFacade facade = context.Items["IACBankAccountDeposit_DetailedFacade"] as Bay.ERP.BusinessFacade.IACBankAccountDeposit_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACBankAccountDeposit_DetailedFacade();
                context.Items["IACBankAccountDeposit_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
