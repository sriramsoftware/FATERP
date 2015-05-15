// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Mar-2013, 04:19:38




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCKBUserTreeShared_Detailed
    {

        public FCCKBUserTreeShared_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IKBUserTreeShared_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IKBUserTreeShared_DetailedFacade facade = context.Items["IKBUserTreeShared_DetailedFacade"] as Bay.ERP.BusinessFacade.IKBUserTreeShared_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.KBUserTreeShared_DetailedFacade();
                context.Items["IKBUserTreeShared_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
