// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-May-2013, 01:11:15




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCINVTransactionINOUT_Custom
    {

        public FCCINVTransactionINOUT_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IINVTransactionINOUT_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IINVTransactionINOUT_CustomFacade facade = context.Items["IINVTransactionINOUT_CustomFacade"] as Bay.ERP.BusinessFacade.IINVTransactionINOUT_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.INVTransactionINOUT_CustomFacade();
                context.Items["IINVTransactionINOUT_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
