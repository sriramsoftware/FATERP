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
    public class FCCKBUserTreeShared
    {

        public FCCKBUserTreeShared()
        {

        }

        public static Bay.ERP.BusinessFacade.IKBUserTreeSharedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IKBUserTreeSharedFacade facade = context.Items["IKBUserTreeSharedFacade"] as Bay.ERP.BusinessFacade.IKBUserTreeSharedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.KBUserTreeSharedFacade();
                context.Items["IKBUserTreeSharedFacade"] = facade;
            }
            return facade;
        }


    }
}
