// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Jul-2013, 12:43:35




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDProcessAssignedResourceMap
    {

        public FCCBDProcessAssignedResourceMap()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProcessAssignedResourceMapFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProcessAssignedResourceMapFacade facade = context.Items["IBDProcessAssignedResourceMapFacade"] as Bay.ERP.BusinessFacade.IBDProcessAssignedResourceMapFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProcessAssignedResourceMapFacade();
                context.Items["IBDProcessAssignedResourceMapFacade"] = facade;
            }
            return facade;
        }


    }
}
