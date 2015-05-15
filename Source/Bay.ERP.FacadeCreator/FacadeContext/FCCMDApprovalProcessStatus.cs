// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 04:20:17




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDApprovalProcessStatus
    {

        public FCCMDApprovalProcessStatus()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDApprovalProcessStatusFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDApprovalProcessStatusFacade facade = context.Items["IMDApprovalProcessStatusFacade"] as Bay.ERP.BusinessFacade.IMDApprovalProcessStatusFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDApprovalProcessStatusFacade();
                context.Items["IMDApprovalProcessStatusFacade"] = facade;
            }
            return facade;
        }


    }
}
