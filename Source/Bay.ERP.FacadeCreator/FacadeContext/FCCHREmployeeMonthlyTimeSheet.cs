// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeMonthlyTimeSheet
    {

        public FCCHREmployeeMonthlyTimeSheet()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeMonthlyTimeSheetFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeMonthlyTimeSheetFacade facade = context.Items["IHREmployeeMonthlyTimeSheetFacade"] as Bay.ERP.BusinessFacade.IHREmployeeMonthlyTimeSheetFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeMonthlyTimeSheetFacade();
                context.Items["IHREmployeeMonthlyTimeSheetFacade"] = facade;
            }
            return facade;
        }


    }
}
