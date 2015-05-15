// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Nov-2013, 09:52:33




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDProcessAssignedResource_Detailed
    {

        public FCCBDProcessAssignedResource_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProcessAssignedResource_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProcessAssignedResource_DetailedFacade facade = context.Items["IBDProcessAssignedResource_DetailedFacade"] as Bay.ERP.BusinessFacade.IBDProcessAssignedResource_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProcessAssignedResource_DetailedFacade();
                context.Items["IBDProcessAssignedResource_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
