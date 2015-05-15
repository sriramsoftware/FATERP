// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMItemBrandMap
    {

        public FCCPRMItemBrandMap()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMItemBrandMapFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMItemBrandMapFacade facade = context.Items["IPRMItemBrandMapFacade"] as Bay.ERP.BusinessFacade.IPRMItemBrandMapFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMItemBrandMapFacade();
                context.Items["IPRMItemBrandMapFacade"] = facade;
            }
            return facade;
        }


    }
}
