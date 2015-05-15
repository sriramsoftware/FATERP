// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Mar-2013, 12:57:49




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACBankAccountTransfer_Detailed
    {

        public FCCACBankAccountTransfer_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IACBankAccountTransfer_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACBankAccountTransfer_DetailedFacade facade = context.Items["IACBankAccountTransfer_DetailedFacade"] as Bay.ERP.BusinessFacade.IACBankAccountTransfer_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACBankAccountTransfer_DetailedFacade();
                context.Items["IACBankAccountTransfer_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
