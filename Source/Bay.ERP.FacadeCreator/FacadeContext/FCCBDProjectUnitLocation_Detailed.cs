// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Oct-2013, 03:32:47




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDProjectUnitLocation_Detailed
    {

        public FCCBDProjectUnitLocation_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProjectUnitLocation_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProjectUnitLocation_DetailedFacade facade = context.Items["IBDProjectUnitLocation_DetailedFacade"] as Bay.ERP.BusinessFacade.IBDProjectUnitLocation_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProjectUnitLocation_DetailedFacade();
                context.Items["IBDProjectUnitLocation_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
