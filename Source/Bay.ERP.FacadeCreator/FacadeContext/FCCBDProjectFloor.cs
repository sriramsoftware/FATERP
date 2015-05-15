// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 02:43:38




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDProjectFloor
    {

        public FCCBDProjectFloor()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProjectFloorFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProjectFloorFacade facade = context.Items["IBDProjectFloorFacade"] as Bay.ERP.BusinessFacade.IBDProjectFloorFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProjectFloorFacade();
                context.Items["IBDProjectFloorFacade"] = facade;
            }
            return facade;
        }


    }
}
