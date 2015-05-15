// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMCustomer
    {

        public FCCCRMCustomer()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMCustomerFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMCustomerFacade facade = context.Items["ICRMCustomerFacade"] as Bay.ERP.BusinessFacade.ICRMCustomerFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMCustomerFacade();
                context.Items["ICRMCustomerFacade"] = facade;
            }
            return facade;
        }


    }
}
