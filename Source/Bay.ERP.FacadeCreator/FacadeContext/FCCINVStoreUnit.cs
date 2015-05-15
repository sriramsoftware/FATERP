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
    public class FCCINVStoreUnit
    {

        public FCCINVStoreUnit()
        {

        }

        public static Bay.ERP.BusinessFacade.IINVStoreUnitFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IINVStoreUnitFacade facade = context.Items["IINVStoreUnitFacade"] as Bay.ERP.BusinessFacade.IINVStoreUnitFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.INVStoreUnitFacade();
                context.Items["IINVStoreUnitFacade"] = facade;
            }
            return facade;
        }


    }
}
