// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2014, 10:14:40




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeExperience_Detailed
    {

        public FCCHREmployeeExperience_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeExperience_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeExperience_DetailedFacade facade = context.Items["IHREmployeeExperience_DetailedFacade"] as Bay.ERP.BusinessFacade.IHREmployeeExperience_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeExperience_DetailedFacade();
                context.Items["IHREmployeeExperience_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
