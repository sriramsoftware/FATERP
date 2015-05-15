// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Oct-2012, 02:11:32




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCAPWOPanelItemCategoryMap_Detailed
    {

        public FCCAPWOPanelItemCategoryMap_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IAPWOPanelItemCategoryMap_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IAPWOPanelItemCategoryMap_DetailedFacade facade = context.Items["IAPWOPanelItemCategoryMap_DetailedFacade"] as Bay.ERP.BusinessFacade.IAPWOPanelItemCategoryMap_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.APWOPanelItemCategoryMap_DetailedFacade();
                context.Items["IAPWOPanelItemCategoryMap_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
