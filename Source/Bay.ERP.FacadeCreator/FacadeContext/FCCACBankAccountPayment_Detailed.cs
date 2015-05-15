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
    public class FCCACBankAccountPayment_Detailed
    {

        public FCCACBankAccountPayment_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IACBankAccountPayment_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACBankAccountPayment_DetailedFacade facade = context.Items["IACBankAccountPayment_DetailedFacade"] as Bay.ERP.BusinessFacade.IACBankAccountPayment_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACBankAccountPayment_DetailedFacade();
                context.Items["IACBankAccountPayment_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
