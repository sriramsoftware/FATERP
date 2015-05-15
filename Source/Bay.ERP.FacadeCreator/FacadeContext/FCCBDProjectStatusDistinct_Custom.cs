// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-May-2012, 04:25:28




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDProjectStatusDistinct_Custom
    {

        public FCCBDProjectStatusDistinct_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProjectStatusDistinct_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProjectStatusDistinct_CustomFacade facade = context.Items["IBDProjectStatusDistinct_CustomFacade"] as Bay.ERP.BusinessFacade.IBDProjectStatusDistinct_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProjectStatusDistinct_CustomFacade();
                context.Items["IBDProjectStatusDistinct_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
