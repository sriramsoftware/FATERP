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
    public class FCCASMemberAspnetUsersMap
    {

        public FCCASMemberAspnetUsersMap()
        {

        }

        public static Bay.ERP.BusinessFacade.IASMemberAspnetUsersMapFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IASMemberAspnetUsersMapFacade facade = context.Items["IASMemberAspnetUsersMapFacade"] as Bay.ERP.BusinessFacade.IASMemberAspnetUsersMapFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ASMemberAspnetUsersMapFacade();
                context.Items["IASMemberAspnetUsersMapFacade"] = facade;
            }
            return facade;
        }


    }
}
