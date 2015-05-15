// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Dec-2013, 03:16:13




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeEvaluationReportForAllEmployee_RPT
    {

        public FCCHREmployeeEvaluationReportForAllEmployee_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeEvaluationReportForAllEmployee_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeEvaluationReportForAllEmployee_RPTFacade facade = context.Items["IHREmployeeEvaluationReportForAllEmployee_RPTFacade"] as Bay.ERP.BusinessFacade.IHREmployeeEvaluationReportForAllEmployee_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeEvaluationReportForAllEmployee_RPTFacade();
                context.Items["IHREmployeeEvaluationReportForAllEmployee_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
