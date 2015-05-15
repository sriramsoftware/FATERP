// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Dec-2013, 10:06:11




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeEvaluationReport_RPT
    {

        public FCCHREmployeeEvaluationReport_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeEvaluationReport_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeEvaluationReport_RPTFacade facade = context.Items["IHREmployeeEvaluationReport_RPTFacade"] as Bay.ERP.BusinessFacade.IHREmployeeEvaluationReport_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeEvaluationReport_RPTFacade();
                context.Items["IHREmployeeEvaluationReport_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
