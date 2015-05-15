// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Aug-2013, 02:50:29




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMMDBillFloorDetailCategory
    {

        public FCCCMMDBillFloorDetailCategory()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMMDBillFloorDetailCategoryFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMMDBillFloorDetailCategoryFacade facade = context.Items["ICMMDBillFloorDetailCategoryFacade"] as Bay.ERP.BusinessFacade.ICMMDBillFloorDetailCategoryFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMMDBillFloorDetailCategoryFacade();
                context.Items["ICMMDBillFloorDetailCategoryFacade"] = facade;
            }
            return facade;
        }


    }
}
