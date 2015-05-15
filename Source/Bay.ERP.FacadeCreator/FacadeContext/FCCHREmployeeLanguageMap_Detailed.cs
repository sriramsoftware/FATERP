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
    public class FCCHREmployeeLanguageMap_Detailed
    {

        public FCCHREmployeeLanguageMap_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeLanguageMap_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeLanguageMap_DetailedFacade facade = context.Items["IHREmployeeLanguageMap_DetailedFacade"] as Bay.ERP.BusinessFacade.IHREmployeeLanguageMap_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeLanguageMap_DetailedFacade();
                context.Items["IHREmployeeLanguageMap_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}