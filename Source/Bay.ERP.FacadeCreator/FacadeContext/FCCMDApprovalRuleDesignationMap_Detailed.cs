// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-May-2012, 02:13:26




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDApprovalRuleDesignationMap_Detailed
    {

        public FCCMDApprovalRuleDesignationMap_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDApprovalRuleDesignationMap_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDApprovalRuleDesignationMap_DetailedFacade facade = context.Items["IMDApprovalRuleDesignationMap_DetailedFacade"] as Bay.ERP.BusinessFacade.IMDApprovalRuleDesignationMap_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDApprovalRuleDesignationMap_DetailedFacade();
                context.Items["IMDApprovalRuleDesignationMap_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}