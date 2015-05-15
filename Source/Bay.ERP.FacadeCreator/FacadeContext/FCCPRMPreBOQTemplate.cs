// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMPreBOQTemplate
    {

        public FCCPRMPreBOQTemplate()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMPreBOQTemplateFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMPreBOQTemplateFacade facade = context.Items["IPRMPreBOQTemplateFacade"] as Bay.ERP.BusinessFacade.IPRMPreBOQTemplateFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMPreBOQTemplateFacade();
                context.Items["IPRMPreBOQTemplateFacade"] = facade;
            }
            return facade;
        }


    }
}
