// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Oct-2013, 12:17:51




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMNMailTemplate
    {

        public FCCCMNMailTemplate()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMNMailTemplateFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMNMailTemplateFacade facade = context.Items["ICMNMailTemplateFacade"] as Bay.ERP.BusinessFacade.ICMNMailTemplateFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMNMailTemplateFacade();
                context.Items["ICMNMailTemplateFacade"] = facade;
            }
            return facade;
        }


    }
}
