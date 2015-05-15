// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Sep-2013, 11:07:00




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeEvaluation
    {

        public FCCHREmployeeEvaluation()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeEvaluationFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeEvaluationFacade facade = context.Items["IHREmployeeEvaluationFacade"] as Bay.ERP.BusinessFacade.IHREmployeeEvaluationFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeEvaluationFacade();
                context.Items["IHREmployeeEvaluationFacade"] = facade;
            }
            return facade;
        }


    }
}
