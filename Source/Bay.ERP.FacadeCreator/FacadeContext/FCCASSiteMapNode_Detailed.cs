// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:34:29




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCASSiteMapNode_Detailed
    {

        public FCCASSiteMapNode_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IASSiteMapNode_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IASSiteMapNode_DetailedFacade facade = context.Items["IASSiteMapNode_DetailedFacade"] as Bay.ERP.BusinessFacade.IASSiteMapNode_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ASSiteMapNode_DetailedFacade();
                context.Items["IASSiteMapNode_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
