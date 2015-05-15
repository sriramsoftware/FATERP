// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:24:04




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCASUserPermissionExcluded
    {

        public FCCASUserPermissionExcluded()
        {

        }

        public static Bay.ERP.BusinessFacade.IASUserPermissionExcludedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IASUserPermissionExcludedFacade facade = context.Items["IASUserPermissionExcludedFacade"] as Bay.ERP.BusinessFacade.IASUserPermissionExcludedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ASUserPermissionExcludedFacade();
                context.Items["IASUserPermissionExcludedFacade"] = facade;
            }
            return facade;
        }


    }
}
