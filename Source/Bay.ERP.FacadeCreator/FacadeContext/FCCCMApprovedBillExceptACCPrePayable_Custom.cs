// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Jan-2013, 01:21:10




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMApprovedBillExceptACCPrePayable_Custom
    {

        public FCCCMApprovedBillExceptACCPrePayable_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMApprovedBillExceptACCPrePayable_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMApprovedBillExceptACCPrePayable_CustomFacade facade = context.Items["ICMApprovedBillExceptACCPrePayable_CustomFacade"] as Bay.ERP.BusinessFacade.ICMApprovedBillExceptACCPrePayable_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMApprovedBillExceptACCPrePayable_CustomFacade();
                context.Items["ICMApprovedBillExceptACCPrePayable_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
