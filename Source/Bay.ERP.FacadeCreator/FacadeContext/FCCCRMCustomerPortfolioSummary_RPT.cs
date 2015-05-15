// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Jun-2013, 02:33:32




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMCustomerPortfolioSummary_RPT
    {

        public FCCCRMCustomerPortfolioSummary_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMCustomerPortfolioSummary_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMCustomerPortfolioSummary_RPTFacade facade = context.Items["ICRMCustomerPortfolioSummary_RPTFacade"] as Bay.ERP.BusinessFacade.ICRMCustomerPortfolioSummary_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMCustomerPortfolioSummary_RPTFacade();
                context.Items["ICRMCustomerPortfolioSummary_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
