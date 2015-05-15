// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Sep-2013, 03:43:17




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeEvaluationSession_Custom
    {

        public FCCHREmployeeEvaluationSession_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeEvaluationSession_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeEvaluationSession_CustomFacade facade = context.Items["IHREmployeeEvaluationSession_CustomFacade"] as Bay.ERP.BusinessFacade.IHREmployeeEvaluationSession_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeEvaluationSession_CustomFacade();
                context.Items["IHREmployeeEvaluationSession_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
