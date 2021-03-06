// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Mar-2013, 04:24:50




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCKBUserTree
    {

        public FCCKBUserTree()
        {

        }

        public static Bay.ERP.BusinessFacade.IKBUserTreeFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IKBUserTreeFacade facade = context.Items["IKBUserTreeFacade"] as Bay.ERP.BusinessFacade.IKBUserTreeFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.KBUserTreeFacade();
                context.Items["IKBUserTreeFacade"] = facade;
            }
            return facade;
        }


    }
}
