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
    public class FCCASPhysicalSiteMap
    {

        public FCCASPhysicalSiteMap()
        {

        }

        public static Bay.ERP.BusinessFacade.IASPhysicalSiteMapFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IASPhysicalSiteMapFacade facade = context.Items["IASPhysicalSiteMapFacade"] as Bay.ERP.BusinessFacade.IASPhysicalSiteMapFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ASPhysicalSiteMapFacade();
                context.Items["IASPhysicalSiteMapFacade"] = facade;
            }
            return facade;
        }


    }
}
