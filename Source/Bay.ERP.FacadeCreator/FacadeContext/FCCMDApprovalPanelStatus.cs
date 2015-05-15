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
    public class FCCMDApprovalPanelStatus
    {

        public FCCMDApprovalPanelStatus()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDApprovalPanelStatusFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDApprovalPanelStatusFacade facade = context.Items["IMDApprovalPanelStatusFacade"] as Bay.ERP.BusinessFacade.IMDApprovalPanelStatusFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDApprovalPanelStatusFacade();
                context.Items["IMDApprovalPanelStatusFacade"] = facade;
            }
            return facade;
        }


    }
}
