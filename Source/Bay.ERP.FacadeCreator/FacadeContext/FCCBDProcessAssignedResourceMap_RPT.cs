// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Jul-2013, 01:40:47




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDProcessAssignedResourceMap_RPT
    {

        public FCCBDProcessAssignedResourceMap_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProcessAssignedResourceMap_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProcessAssignedResourceMap_RPTFacade facade = context.Items["IBDProcessAssignedResourceMap_RPTFacade"] as Bay.ERP.BusinessFacade.IBDProcessAssignedResourceMap_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProcessAssignedResourceMap_RPTFacade();
                context.Items["IBDProcessAssignedResourceMap_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
