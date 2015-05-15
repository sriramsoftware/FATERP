// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2013, 08:24:37




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMAgreement
    {

        public FCCCRMAgreement()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMAgreementFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMAgreementFacade facade = context.Items["ICRMAgreementFacade"] as Bay.ERP.BusinessFacade.ICRMAgreementFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMAgreementFacade();
                context.Items["ICRMAgreementFacade"] = facade;
            }
            return facade;
        }


    }
}
