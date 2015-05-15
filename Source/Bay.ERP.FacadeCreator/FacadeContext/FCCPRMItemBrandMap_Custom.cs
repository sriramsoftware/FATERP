// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Apr-2012, 04:01:11




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMItemBrandMap_Custom
    {

        public FCCPRMItemBrandMap_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMItemBrandMap_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMItemBrandMap_CustomFacade facade = context.Items["IPRMItemBrandMap_CustomFacade"] as Bay.ERP.BusinessFacade.IPRMItemBrandMap_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMItemBrandMap_CustomFacade();
                context.Items["IPRMItemBrandMap_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
