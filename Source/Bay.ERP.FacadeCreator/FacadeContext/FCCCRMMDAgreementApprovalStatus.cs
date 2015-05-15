// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Apr-2013, 01:28:07




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMMDAgreementApprovalStatus
    {

        public FCCCRMMDAgreementApprovalStatus()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMMDAgreementApprovalStatusFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMMDAgreementApprovalStatusFacade facade = context.Items["ICRMMDAgreementApprovalStatusFacade"] as Bay.ERP.BusinessFacade.ICRMMDAgreementApprovalStatusFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMMDAgreementApprovalStatusFacade();
                context.Items["ICRMMDAgreementApprovalStatusFacade"] = facade;
            }
            return facade;
        }


    }
}
