// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Mar-2013, 04:14:01




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCKBMDUserTreeSharedPermission
    {

        public FCCKBMDUserTreeSharedPermission()
        {

        }

        public static Bay.ERP.BusinessFacade.IKBMDUserTreeSharedPermissionFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IKBMDUserTreeSharedPermissionFacade facade = context.Items["IKBMDUserTreeSharedPermissionFacade"] as Bay.ERP.BusinessFacade.IKBMDUserTreeSharedPermissionFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.KBMDUserTreeSharedPermissionFacade();
                context.Items["IKBMDUserTreeSharedPermissionFacade"] = facade;
            }
            return facade;
        }


    }
}
