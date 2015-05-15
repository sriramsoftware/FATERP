// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jun-2012, 05:50:09




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMWorkOrderPaymentTerm
    {

        public FCCPRMWorkOrderPaymentTerm()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMWorkOrderPaymentTermFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMWorkOrderPaymentTermFacade facade = context.Items["IPRMWorkOrderPaymentTermFacade"] as Bay.ERP.BusinessFacade.IPRMWorkOrderPaymentTermFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMWorkOrderPaymentTermFacade();
                context.Items["IPRMWorkOrderPaymentTermFacade"] = facade;
            }
            return facade;
        }


    }
}