// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 12:52:14




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDStoreIssueNoteApprovalStatus
    {

        public FCCMDStoreIssueNoteApprovalStatus()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDStoreIssueNoteApprovalStatusFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDStoreIssueNoteApprovalStatusFacade facade = context.Items["IMDStoreIssueNoteApprovalStatusFacade"] as Bay.ERP.BusinessFacade.IMDStoreIssueNoteApprovalStatusFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDStoreIssueNoteApprovalStatusFacade();
                context.Items["IMDStoreIssueNoteApprovalStatusFacade"] = facade;
            }
            return facade;
        }


    }
}
