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
    public class FCCCRMAgreementTemplate
    {

        public FCCCRMAgreementTemplate()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMAgreementTemplateFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMAgreementTemplateFacade facade = context.Items["ICRMAgreementTemplateFacade"] as Bay.ERP.BusinessFacade.ICRMAgreementTemplateFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMAgreementTemplateFacade();
                context.Items["ICRMAgreementTemplateFacade"] = facade;
            }
            return facade;
        }


    }
}
