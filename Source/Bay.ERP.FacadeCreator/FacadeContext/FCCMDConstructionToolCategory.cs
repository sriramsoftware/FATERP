// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jan-2012, 03:00:49




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDConstructionToolCategory
    {

        public FCCMDConstructionToolCategory()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDConstructionToolCategoryFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDConstructionToolCategoryFacade facade = context.Items["IMDConstructionToolCategoryFacade"] as Bay.ERP.BusinessFacade.IMDConstructionToolCategoryFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDConstructionToolCategoryFacade();
                context.Items["IMDConstructionToolCategoryFacade"] = facade;
            }
            return facade;
        }


    }
}
