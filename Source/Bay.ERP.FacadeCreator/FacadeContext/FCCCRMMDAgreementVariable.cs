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
    public class FCCCRMMDAgreementVariable
    {

        public FCCCRMMDAgreementVariable()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMMDAgreementVariableFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMMDAgreementVariableFacade facade = context.Items["ICRMMDAgreementVariableFacade"] as Bay.ERP.BusinessFacade.ICRMMDAgreementVariableFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMMDAgreementVariableFacade();
                context.Items["ICRMMDAgreementVariableFacade"] = facade;
            }
            return facade;
        }


    }
}