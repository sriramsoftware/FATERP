// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Jan-2013, 05:31:41




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCINVTransactionAvailableQtyWithBatch_Custom
    {

        public FCCINVTransactionAvailableQtyWithBatch_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IINVTransactionAvailableQtyWithBatch_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IINVTransactionAvailableQtyWithBatch_CustomFacade facade = context.Items["IINVTransactionAvailableQtyWithBatch_CustomFacade"] as Bay.ERP.BusinessFacade.IINVTransactionAvailableQtyWithBatch_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.INVTransactionAvailableQtyWithBatch_CustomFacade();
                context.Items["IINVTransactionAvailableQtyWithBatch_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
