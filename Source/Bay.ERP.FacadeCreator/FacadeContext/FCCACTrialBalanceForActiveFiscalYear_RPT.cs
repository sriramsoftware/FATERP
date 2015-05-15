// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Feb-2013, 10:20:31




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACTrialBalanceForActiveFiscalYear_RPT
    {

        public FCCACTrialBalanceForActiveFiscalYear_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IACTrialBalanceForActiveFiscalYear_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACTrialBalanceForActiveFiscalYear_RPTFacade facade = context.Items["IACTrialBalanceForActiveFiscalYear_RPTFacade"] as Bay.ERP.BusinessFacade.IACTrialBalanceForActiveFiscalYear_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACTrialBalanceForActiveFiscalYear_RPTFacade();
                context.Items["IACTrialBalanceForActiveFiscalYear_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
