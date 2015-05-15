// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Dec-2012, 11:15:25




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCINVTransferItem
    {

        public FCCINVTransferItem()
        {

        }

        public static Bay.ERP.BusinessFacade.IINVTransferItemFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IINVTransferItemFacade facade = context.Items["IINVTransferItemFacade"] as Bay.ERP.BusinessFacade.IINVTransferItemFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.INVTransferItemFacade();
                context.Items["IINVTransferItemFacade"] = facade;
            }
            return facade;
        }


    }
}
