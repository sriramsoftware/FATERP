// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-May-2012, 10:39:09




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDProjectFloor_Detailed
    {

        public FCCBDProjectFloor_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProjectFloor_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProjectFloor_DetailedFacade facade = context.Items["IBDProjectFloor_DetailedFacade"] as Bay.ERP.BusinessFacade.IBDProjectFloor_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProjectFloor_DetailedFacade();
                context.Items["IBDProjectFloor_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
