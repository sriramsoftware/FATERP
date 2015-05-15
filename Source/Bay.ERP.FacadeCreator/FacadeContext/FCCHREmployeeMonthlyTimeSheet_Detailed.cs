// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Dec-2013, 11:16:35




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeMonthlyTimeSheet_Detailed
    {

        public FCCHREmployeeMonthlyTimeSheet_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeMonthlyTimeSheet_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeMonthlyTimeSheet_DetailedFacade facade = context.Items["IHREmployeeMonthlyTimeSheet_DetailedFacade"] as Bay.ERP.BusinessFacade.IHREmployeeMonthlyTimeSheet_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeMonthlyTimeSheet_DetailedFacade();
                context.Items["IHREmployeeMonthlyTimeSheet_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
