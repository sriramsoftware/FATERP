// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2012, 09:48:54




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCAPPanelItemCategoryMap_Custom
    {

        public FCCAPPanelItemCategoryMap_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IAPPanelItemCategoryMap_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IAPPanelItemCategoryMap_CustomFacade facade = context.Items["IAPPanelItemCategoryMap_CustomFacade"] as Bay.ERP.BusinessFacade.IAPPanelItemCategoryMap_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.APPanelItemCategoryMap_CustomFacade();
                context.Items["IAPPanelItemCategoryMap_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
