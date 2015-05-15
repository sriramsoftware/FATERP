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
    public class FCCACBankAccountPaymentDateWise_RPT
    {

        public FCCACBankAccountPaymentDateWise_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IACBankAccountPaymentDateWise_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACBankAccountPaymentDateWise_RPTFacade facade = context.Items["IACBankAccountPaymentDateWise_RPTFacade"] as Bay.ERP.BusinessFacade.IACBankAccountPaymentDateWise_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACBankAccountPaymentDateWise_RPTFacade();
                context.Items["IACBankAccountPaymentDateWise_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
