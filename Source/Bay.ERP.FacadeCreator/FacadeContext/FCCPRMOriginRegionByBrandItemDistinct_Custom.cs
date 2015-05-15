// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Jul-2012, 02:21:44




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMOriginRegionByBrandItemDistinct_Custom
    {

        public FCCPRMOriginRegionByBrandItemDistinct_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMOriginRegionByBrandItemDistinct_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMOriginRegionByBrandItemDistinct_CustomFacade facade = context.Items["IPRMOriginRegionByBrandItemDistinct_CustomFacade"] as Bay.ERP.BusinessFacade.IPRMOriginRegionByBrandItemDistinct_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMOriginRegionByBrandItemDistinct_CustomFacade();
                context.Items["IPRMOriginRegionByBrandItemDistinct_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
