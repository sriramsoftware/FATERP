// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 02:50:43




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACBudget
    {

        public FCCACBudget()
        {

        }

        public static Bay.ERP.BusinessFacade.IACBudgetFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACBudgetFacade facade = context.Items["IACBudgetFacade"] as Bay.ERP.BusinessFacade.IACBudgetFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACBudgetFacade();
                context.Items["IACBudgetFacade"] = facade;
            }
            return facade;
        }


    }
}
