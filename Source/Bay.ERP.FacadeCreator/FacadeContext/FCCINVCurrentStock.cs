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
    public class FCCINVCurrentStock
    {

        public FCCINVCurrentStock()
        {

        }

        public static Bay.ERP.BusinessFacade.IINVCurrentStockFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IINVCurrentStockFacade facade = context.Items["IINVCurrentStockFacade"] as Bay.ERP.BusinessFacade.IINVCurrentStockFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.INVCurrentStockFacade();
                context.Items["IINVCurrentStockFacade"] = facade;
            }
            return facade;
        }


    }
}
