// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2012, 10:59:14




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCAPWOPanelItemCategoryMap
    {

        public FCCAPWOPanelItemCategoryMap()
        {

        }

        public static Bay.ERP.BusinessFacade.IAPWOPanelItemCategoryMapFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IAPWOPanelItemCategoryMapFacade facade = context.Items["IAPWOPanelItemCategoryMapFacade"] as Bay.ERP.BusinessFacade.IAPWOPanelItemCategoryMapFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.APWOPanelItemCategoryMapFacade();
                context.Items["IAPWOPanelItemCategoryMapFacade"] = facade;
            }
            return facade;
        }


    }
}
