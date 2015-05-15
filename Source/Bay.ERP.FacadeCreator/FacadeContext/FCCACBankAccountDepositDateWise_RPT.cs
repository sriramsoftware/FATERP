// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jul-2013, 11:29:54




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACBankAccountDepositDateWise_RPT
    {

        public FCCACBankAccountDepositDateWise_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IACBankAccountDepositDateWise_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACBankAccountDepositDateWise_RPTFacade facade = context.Items["IACBankAccountDepositDateWise_RPTFacade"] as Bay.ERP.BusinessFacade.IACBankAccountDepositDateWise_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACBankAccountDepositDateWise_RPTFacade();
                context.Items["IACBankAccountDepositDateWise_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
