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
    public class FCCASRolePermission
    {

        public FCCASRolePermission()
        {

        }

        public static Bay.ERP.BusinessFacade.IASRolePermissionFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IASRolePermissionFacade facade = context.Items["IASRolePermissionFacade"] as Bay.ERP.BusinessFacade.IASRolePermissionFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ASRolePermissionFacade();
                context.Items["IASRolePermissionFacade"] = facade;
            }
            return facade;
        }


    }
}
