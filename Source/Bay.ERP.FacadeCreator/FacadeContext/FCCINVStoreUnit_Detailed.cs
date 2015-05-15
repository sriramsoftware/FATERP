// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Dec-2012, 10:49:09




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCINVStoreUnit_Detailed
    {

        public FCCINVStoreUnit_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IINVStoreUnit_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IINVStoreUnit_DetailedFacade facade = context.Items["IINVStoreUnit_DetailedFacade"] as Bay.ERP.BusinessFacade.IINVStoreUnit_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.INVStoreUnit_DetailedFacade();
                context.Items["IINVStoreUnit_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
