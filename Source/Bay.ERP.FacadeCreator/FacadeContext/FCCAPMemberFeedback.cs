// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Oct-2012, 11:32:20




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCAPMemberFeedback
    {

        public FCCAPMemberFeedback()
        {

        }

        public static Bay.ERP.BusinessFacade.IAPMemberFeedbackFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IAPMemberFeedbackFacade facade = context.Items["IAPMemberFeedbackFacade"] as Bay.ERP.BusinessFacade.IAPMemberFeedbackFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.APMemberFeedbackFacade();
                context.Items["IAPMemberFeedbackFacade"] = facade;
            }
            return facade;
        }


    }
}
