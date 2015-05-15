// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Feb-2013, 02:55:33




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACTrialBalance_Custom
    {

        public FCCACTrialBalance_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IACTrialBalance_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACTrialBalance_CustomFacade facade = context.Items["IACTrialBalance_CustomFacade"] as Bay.ERP.BusinessFacade.IACTrialBalance_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACTrialBalance_CustomFacade();
                context.Items["IACTrialBalance_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
