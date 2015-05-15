// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Sep-2013, 02:21:03




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeEvaluationIndividual_Custom
    {

        public FCCHREmployeeEvaluationIndividual_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeEvaluationIndividual_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeEvaluationIndividual_CustomFacade facade = context.Items["IHREmployeeEvaluationIndividual_CustomFacade"] as Bay.ERP.BusinessFacade.IHREmployeeEvaluationIndividual_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeEvaluationIndividual_CustomFacade();
                context.Items["IHREmployeeEvaluationIndividual_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
