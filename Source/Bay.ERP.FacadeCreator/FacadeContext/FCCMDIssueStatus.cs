// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDIssueStatus
    {

        public FCCMDIssueStatus()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDIssueStatusFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDIssueStatusFacade facade = context.Items["IMDIssueStatusFacade"] as Bay.ERP.BusinessFacade.IMDIssueStatusFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDIssueStatusFacade();
                context.Items["IMDIssueStatusFacade"] = facade;
            }
            return facade;
        }


    }
}
