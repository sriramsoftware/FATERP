// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeExperience
    {

        public FCCHREmployeeExperience()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeExperienceFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeExperienceFacade facade = context.Items["IHREmployeeExperienceFacade"] as Bay.ERP.BusinessFacade.IHREmployeeExperienceFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeExperienceFacade();
                context.Items["IHREmployeeExperienceFacade"] = facade;
            }
            return facade;
        }


    }
}
