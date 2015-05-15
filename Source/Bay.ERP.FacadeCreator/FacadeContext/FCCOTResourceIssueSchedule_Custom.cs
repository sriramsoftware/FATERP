// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jun-2012, 11:27:18




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCOTResourceIssueSchedule_Custom
    {

        public FCCOTResourceIssueSchedule_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IOTResourceIssueSchedule_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IOTResourceIssueSchedule_CustomFacade facade = context.Items["IOTResourceIssueSchedule_CustomFacade"] as Bay.ERP.BusinessFacade.IOTResourceIssueSchedule_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.OTResourceIssueSchedule_CustomFacade();
                context.Items["IOTResourceIssueSchedule_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
