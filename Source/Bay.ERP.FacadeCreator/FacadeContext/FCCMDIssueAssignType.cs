// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Mar-2013, 11:29:57




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDIssueAssignType
    {

        public FCCMDIssueAssignType()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDIssueAssignTypeFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDIssueAssignTypeFacade facade = context.Items["IMDIssueAssignTypeFacade"] as Bay.ERP.BusinessFacade.IMDIssueAssignTypeFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDIssueAssignTypeFacade();
                context.Items["IMDIssueAssignTypeFacade"] = facade;
            }
            return facade;
        }


    }
}
