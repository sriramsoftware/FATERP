// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Feb-2013, 11:32:26




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACBankStatement_Custom
    {

        public FCCACBankStatement_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IACBankStatement_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACBankStatement_CustomFacade facade = context.Items["IACBankStatement_CustomFacade"] as Bay.ERP.BusinessFacade.IACBankStatement_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACBankStatement_CustomFacade();
                context.Items["IACBankStatement_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
