// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHRMemberLeaveOpeningBalance
    {

        public FCCHRMemberLeaveOpeningBalance()
        {

        }

        public static Bay.ERP.BusinessFacade.IHRMemberLeaveOpeningBalanceFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHRMemberLeaveOpeningBalanceFacade facade = context.Items["IHRMemberLeaveOpeningBalanceFacade"] as Bay.ERP.BusinessFacade.IHRMemberLeaveOpeningBalanceFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HRMemberLeaveOpeningBalanceFacade();
                context.Items["IHRMemberLeaveOpeningBalanceFacade"] = facade;
            }
            return facade;
        }


    }
}
