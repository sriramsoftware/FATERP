// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-May-2013, 01:34:06




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMPaymentCollection_Detailed
    {

        public FCCCRMPaymentCollection_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMPaymentCollection_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMPaymentCollection_DetailedFacade facade = context.Items["ICRMPaymentCollection_DetailedFacade"] as Bay.ERP.BusinessFacade.ICRMPaymentCollection_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMPaymentCollection_DetailedFacade();
                context.Items["ICRMPaymentCollection_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
