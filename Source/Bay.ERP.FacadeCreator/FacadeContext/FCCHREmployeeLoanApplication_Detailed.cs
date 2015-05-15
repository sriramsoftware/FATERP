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
    public class FCCHREmployeeLoanApplication_Detailed
    {

        public FCCHREmployeeLoanApplication_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeLoanApplication_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeLoanApplication_DetailedFacade facade = context.Items["IHREmployeeLoanApplication_DetailedFacade"] as Bay.ERP.BusinessFacade.IHREmployeeLoanApplication_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeLoanApplication_DetailedFacade();
                context.Items["IHREmployeeLoanApplication_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
