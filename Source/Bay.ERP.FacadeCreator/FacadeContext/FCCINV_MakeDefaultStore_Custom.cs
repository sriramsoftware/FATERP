// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 03:50:26




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCINV_MakeDefaultStore_Custom
    {

        public FCCINV_MakeDefaultStore_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IINV_MakeDefaultStore_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IINV_MakeDefaultStore_CustomFacade facade = context.Items["IINV_MakeDefaultStore_CustomFacade"] as Bay.ERP.BusinessFacade.IINV_MakeDefaultStore_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.INV_MakeDefaultStore_CustomFacade();
                context.Items["IINV_MakeDefaultStore_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
