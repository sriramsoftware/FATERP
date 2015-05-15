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
    public class FCCMDFloorUnitLocationCategory
    {

        public FCCMDFloorUnitLocationCategory()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDFloorUnitLocationCategoryFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDFloorUnitLocationCategoryFacade facade = context.Items["IMDFloorUnitLocationCategoryFacade"] as Bay.ERP.BusinessFacade.IMDFloorUnitLocationCategoryFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDFloorUnitLocationCategoryFacade();
                context.Items["IMDFloorUnitLocationCategoryFacade"] = facade;
            }
            return facade;
        }


    }
}
