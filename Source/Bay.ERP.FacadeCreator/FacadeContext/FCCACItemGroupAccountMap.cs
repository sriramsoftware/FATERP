// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACItemGroupAccountMap
    {

        public FCCACItemGroupAccountMap()
        {

        }

        public static Bay.ERP.BusinessFacade.IACItemGroupAccountMapFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACItemGroupAccountMapFacade facade = context.Items["IACItemGroupAccountMapFacade"] as Bay.ERP.BusinessFacade.IACItemGroupAccountMapFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACItemGroupAccountMapFacade();
                context.Items["IACItemGroupAccountMapFacade"] = facade;
            }
            return facade;
        }


    }
}
