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
    public class FCCHREmployeeFamilyInfo_Detailed
    {

        public FCCHREmployeeFamilyInfo_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeFamilyInfo_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeFamilyInfo_DetailedFacade facade = context.Items["IHREmployeeFamilyInfo_DetailedFacade"] as Bay.ERP.BusinessFacade.IHREmployeeFamilyInfo_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeFamilyInfo_DetailedFacade();
                context.Items["IHREmployeeFamilyInfo_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
