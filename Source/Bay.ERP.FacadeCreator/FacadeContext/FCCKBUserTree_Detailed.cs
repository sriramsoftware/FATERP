// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Mar-2013, 12:53:07




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCKBUserTree_Detailed
    {

        public FCCKBUserTree_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IKBUserTree_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IKBUserTree_DetailedFacade facade = context.Items["IKBUserTree_DetailedFacade"] as Bay.ERP.BusinessFacade.IKBUserTree_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.KBUserTree_DetailedFacade();
                context.Items["IKBUserTree_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
