// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jun-2013, 03:54:41




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACAccountResourceAccountMap
    {

        public FCCACAccountResourceAccountMap()
        {

        }

        public static Bay.ERP.BusinessFacade.IACAccountResourceAccountMapFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACAccountResourceAccountMapFacade facade = context.Items["IACAccountResourceAccountMapFacade"] as Bay.ERP.BusinessFacade.IACAccountResourceAccountMapFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACAccountResourceAccountMapFacade();
                context.Items["IACAccountResourceAccountMapFacade"] = facade;
            }
            return facade;
        }


    }
}
