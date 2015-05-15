// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Apr-2013, 03:03:13




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDProjectFloorUnit_Detailed
    {

        public FCCBDProjectFloorUnit_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProjectFloorUnit_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProjectFloorUnit_DetailedFacade facade = context.Items["IBDProjectFloorUnit_DetailedFacade"] as Bay.ERP.BusinessFacade.IBDProjectFloorUnit_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProjectFloorUnit_DetailedFacade();
                context.Items["IBDProjectFloorUnit_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
