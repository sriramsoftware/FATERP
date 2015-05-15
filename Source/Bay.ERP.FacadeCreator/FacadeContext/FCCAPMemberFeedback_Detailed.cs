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
    public class FCCAPMemberFeedback_Detailed
    {

        public FCCAPMemberFeedback_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IAPMemberFeedback_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IAPMemberFeedback_DetailedFacade facade = context.Items["IAPMemberFeedback_DetailedFacade"] as Bay.ERP.BusinessFacade.IAPMemberFeedback_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.APMemberFeedback_DetailedFacade();
                context.Items["IAPMemberFeedback_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}