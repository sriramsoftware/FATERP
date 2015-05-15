// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-May-2012, 10:39:09




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMNEventInvitationInformation_Detailed
    {

        public FCCCMNEventInvitationInformation_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMNEventInvitationInformation_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMNEventInvitationInformation_DetailedFacade facade = context.Items["ICMNEventInvitationInformation_DetailedFacade"] as Bay.ERP.BusinessFacade.ICMNEventInvitationInformation_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMNEventInvitationInformation_DetailedFacade();
                context.Items["ICMNEventInvitationInformation_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
