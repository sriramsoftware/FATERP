// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 04:44:22




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACBudget_Detailed
    {

        public FCCACBudget_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IACBudget_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACBudget_DetailedFacade facade = context.Items["IACBudget_DetailedFacade"] as Bay.ERP.BusinessFacade.IACBudget_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACBudget_DetailedFacade();
                context.Items["IACBudget_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
