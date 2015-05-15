// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:24:04




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCASSiteMapNode
    {

        public FCCASSiteMapNode()
        {

        }

        public static Bay.ERP.BusinessFacade.IASSiteMapNodeFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IASSiteMapNodeFacade facade = context.Items["IASSiteMapNodeFacade"] as Bay.ERP.BusinessFacade.IASSiteMapNodeFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ASSiteMapNodeFacade();
                context.Items["IASSiteMapNodeFacade"] = facade;
            }
            return facade;
        }


    }
}
