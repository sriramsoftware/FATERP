// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Nov-2013, 12:21:52




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDEventInvitatedPersonType
    {

        public FCCMDEventInvitatedPersonType()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDEventInvitatedPersonTypeFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDEventInvitatedPersonTypeFacade facade = context.Items["IMDEventInvitatedPersonTypeFacade"] as Bay.ERP.BusinessFacade.IMDEventInvitatedPersonTypeFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDEventInvitatedPersonTypeFacade();
                context.Items["IMDEventInvitatedPersonTypeFacade"] = facade;
            }
            return facade;
        }


    }
}
