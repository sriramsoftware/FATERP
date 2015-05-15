// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Jul-2013, 10:23:15




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACBankAccountDeposit_RPT
    {

        public FCCACBankAccountDeposit_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IACBankAccountDeposit_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACBankAccountDeposit_RPTFacade facade = context.Items["IACBankAccountDeposit_RPTFacade"] as Bay.ERP.BusinessFacade.IACBankAccountDeposit_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACBankAccountDeposit_RPTFacade();
                context.Items["IACBankAccountDeposit_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
