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
    public class FCCASSiteMap
    {

        public FCCASSiteMap()
        {

        }

        public static Bay.ERP.BusinessFacade.IASSiteMapFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IASSiteMapFacade facade = context.Items["IASSiteMapFacade"] as Bay.ERP.BusinessFacade.IASSiteMapFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ASSiteMapFacade();
                context.Items["IASSiteMapFacade"] = facade;
            }
            return facade;
        }


    }
}
