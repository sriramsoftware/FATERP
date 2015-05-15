// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Jan-2014, 01:58:57




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeMonthlyTimeSheetSummary_RPT
    {

        public FCCHREmployeeMonthlyTimeSheetSummary_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeMonthlyTimeSheetSummary_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeMonthlyTimeSheetSummary_RPTFacade facade = context.Items["IHREmployeeMonthlyTimeSheetSummary_RPTFacade"] as Bay.ERP.BusinessFacade.IHREmployeeMonthlyTimeSheetSummary_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeMonthlyTimeSheetSummary_RPTFacade();
                context.Items["IHREmployeeMonthlyTimeSheetSummary_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
