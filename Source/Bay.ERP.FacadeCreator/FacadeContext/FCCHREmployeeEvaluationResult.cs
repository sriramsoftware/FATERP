// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Sep-2013, 01:18:06




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeEvaluationResult
    {

        public FCCHREmployeeEvaluationResult()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeEvaluationResultFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeEvaluationResultFacade facade = context.Items["IHREmployeeEvaluationResultFacade"] as Bay.ERP.BusinessFacade.IHREmployeeEvaluationResultFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeEvaluationResultFacade();
                context.Items["IHREmployeeEvaluationResultFacade"] = facade;
            }
            return facade;
        }


    }
}
