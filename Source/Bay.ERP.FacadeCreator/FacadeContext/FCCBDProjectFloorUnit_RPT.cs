// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Feb-2013, 12:00:23




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDProjectFloorUnit_RPT
    {

        public FCCBDProjectFloorUnit_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProjectFloorUnit_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProjectFloorUnit_RPTFacade facade = context.Items["IBDProjectFloorUnit_RPTFacade"] as Bay.ERP.BusinessFacade.IBDProjectFloorUnit_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProjectFloorUnit_RPTFacade();
                context.Items["IBDProjectFloorUnit_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
