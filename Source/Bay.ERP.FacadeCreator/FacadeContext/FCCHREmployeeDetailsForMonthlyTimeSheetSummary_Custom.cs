// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Jan-2014, 04:42:27




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeDetailsForMonthlyTimeSheetSummary_Custom
    {

        public FCCHREmployeeDetailsForMonthlyTimeSheetSummary_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeDetailsForMonthlyTimeSheetSummary_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeDetailsForMonthlyTimeSheetSummary_CustomFacade facade = context.Items["IHREmployeeDetailsForMonthlyTimeSheetSummary_CustomFacade"] as Bay.ERP.BusinessFacade.IHREmployeeDetailsForMonthlyTimeSheetSummary_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeDetailsForMonthlyTimeSheetSummary_CustomFacade();
                context.Items["IHREmployeeDetailsForMonthlyTimeSheetSummary_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
