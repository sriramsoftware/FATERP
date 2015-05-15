// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Dec-2013, 01:17:51




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeEvaluationReport
    {

        public FCCHREmployeeEvaluationReport()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeEvaluationReportFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeEvaluationReportFacade facade = context.Items["IHREmployeeEvaluationReportFacade"] as Bay.ERP.BusinessFacade.IHREmployeeEvaluationReportFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeEvaluationReportFacade();
                context.Items["IHREmployeeEvaluationReportFacade"] = facade;
            }
            return facade;
        }


    }
}
