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
    public class FCCINVTransaction
    {

        public FCCINVTransaction()
        {

        }

        public static Bay.ERP.BusinessFacade.IINVTransactionFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IINVTransactionFacade facade = context.Items["IINVTransactionFacade"] as Bay.ERP.BusinessFacade.IINVTransactionFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.INVTransactionFacade();
                context.Items["IINVTransactionFacade"] = facade;
            }
            return facade;
        }


    }
}
