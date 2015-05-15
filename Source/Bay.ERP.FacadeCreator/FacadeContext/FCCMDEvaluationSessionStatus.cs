// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Sep-2013, 03:21:45




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDEvaluationSessionStatus
    {

        public FCCMDEvaluationSessionStatus()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDEvaluationSessionStatusFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDEvaluationSessionStatusFacade facade = context.Items["IMDEvaluationSessionStatusFacade"] as Bay.ERP.BusinessFacade.IMDEvaluationSessionStatusFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDEvaluationSessionStatusFacade();
                context.Items["IMDEvaluationSessionStatusFacade"] = facade;
            }
            return facade;
        }


    }
}
