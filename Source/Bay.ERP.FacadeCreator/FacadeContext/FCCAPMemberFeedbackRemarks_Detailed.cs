// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Oct-2012, 11:49:00




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCAPMemberFeedbackRemarks_Detailed
    {

        public FCCAPMemberFeedbackRemarks_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IAPMemberFeedbackRemarks_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IAPMemberFeedbackRemarks_DetailedFacade facade = context.Items["IAPMemberFeedbackRemarks_DetailedFacade"] as Bay.ERP.BusinessFacade.IAPMemberFeedbackRemarks_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.APMemberFeedbackRemarks_DetailedFacade();
                context.Items["IAPMemberFeedbackRemarks_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
