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
    public class FCCMDEvaluationSessionCategory
    {

        public FCCMDEvaluationSessionCategory()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDEvaluationSessionCategoryFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDEvaluationSessionCategoryFacade facade = context.Items["IMDEvaluationSessionCategoryFacade"] as Bay.ERP.BusinessFacade.IMDEvaluationSessionCategoryFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDEvaluationSessionCategoryFacade();
                context.Items["IMDEvaluationSessionCategoryFacade"] = facade;
            }
            return facade;
        }


    }
}
