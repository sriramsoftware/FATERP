// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Mar-2013, 10:27:29




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACBankAccountTransfer
    {

        public FCCACBankAccountTransfer()
        {

        }

        public static Bay.ERP.BusinessFacade.IACBankAccountTransferFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACBankAccountTransferFacade facade = context.Items["IACBankAccountTransferFacade"] as Bay.ERP.BusinessFacade.IACBankAccountTransferFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACBankAccountTransferFacade();
                context.Items["IACBankAccountTransferFacade"] = facade;
            }
            return facade;
        }


    }
}
