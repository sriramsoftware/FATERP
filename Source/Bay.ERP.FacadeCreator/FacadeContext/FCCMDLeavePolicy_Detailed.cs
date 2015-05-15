// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2013, 05:23:47




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDLeavePolicy_Detailed
    {

        public FCCMDLeavePolicy_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDLeavePolicy_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDLeavePolicy_DetailedFacade facade = context.Items["IMDLeavePolicy_DetailedFacade"] as Bay.ERP.BusinessFacade.IMDLeavePolicy_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDLeavePolicy_DetailedFacade();
                context.Items["IMDLeavePolicy_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}