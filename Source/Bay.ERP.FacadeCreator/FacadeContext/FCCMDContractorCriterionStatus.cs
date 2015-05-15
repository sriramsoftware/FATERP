// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDContractorCriterionStatus
    {

        public FCCMDContractorCriterionStatus()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDContractorCriterionStatusFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDContractorCriterionStatusFacade facade = context.Items["IMDContractorCriterionStatusFacade"] as Bay.ERP.BusinessFacade.IMDContractorCriterionStatusFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDContractorCriterionStatusFacade();
                context.Items["IMDContractorCriterionStatusFacade"] = facade;
            }
            return facade;
        }


    }
}
