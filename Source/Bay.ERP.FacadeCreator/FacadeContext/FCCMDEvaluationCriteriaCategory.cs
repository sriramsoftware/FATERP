// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Sep-2013, 01:19:45




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDEvaluationCriteriaCategory
    {

        public FCCMDEvaluationCriteriaCategory()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDEvaluationCriteriaCategoryFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDEvaluationCriteriaCategoryFacade facade = context.Items["IMDEvaluationCriteriaCategoryFacade"] as Bay.ERP.BusinessFacade.IMDEvaluationCriteriaCategoryFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDEvaluationCriteriaCategoryFacade();
                context.Items["IMDEvaluationCriteriaCategoryFacade"] = facade;
            }
            return facade;
        }


    }
}
