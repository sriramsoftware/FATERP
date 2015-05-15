// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Mar-2013, 11:12:01




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDMaterialReceiveApprovalStatus
    {

        public FCCMDMaterialReceiveApprovalStatus()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDMaterialReceiveApprovalStatusFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDMaterialReceiveApprovalStatusFacade facade = context.Items["IMDMaterialReceiveApprovalStatusFacade"] as Bay.ERP.BusinessFacade.IMDMaterialReceiveApprovalStatusFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDMaterialReceiveApprovalStatusFacade();
                context.Items["IMDMaterialReceiveApprovalStatusFacade"] = facade;
            }
            return facade;
        }


    }
}
