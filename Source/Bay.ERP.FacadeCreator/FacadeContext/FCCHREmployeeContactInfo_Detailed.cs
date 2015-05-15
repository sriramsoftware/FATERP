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
    public class FCCHREmployeeContactInfo_Detailed
    {

        public FCCHREmployeeContactInfo_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeContactInfo_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeContactInfo_DetailedFacade facade = context.Items["IHREmployeeContactInfo_DetailedFacade"] as Bay.ERP.BusinessFacade.IHREmployeeContactInfo_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeContactInfo_DetailedFacade();
                context.Items["IHREmployeeContactInfo_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
