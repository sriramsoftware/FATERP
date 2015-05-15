// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 12:52:14




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCINVStoreUnitItem
    {

        public FCCINVStoreUnitItem()
        {

        }

        public static Bay.ERP.BusinessFacade.IINVStoreUnitItemFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IINVStoreUnitItemFacade facade = context.Items["IINVStoreUnitItemFacade"] as Bay.ERP.BusinessFacade.IINVStoreUnitItemFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.INVStoreUnitItemFacade();
                context.Items["IINVStoreUnitItemFacade"] = facade;
            }
            return facade;
        }


    }
}
