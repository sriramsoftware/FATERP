// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Jun-2012, 01:41:44




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMWorkOrderPaymentTerm_RPT
    {

        public FCCPRMWorkOrderPaymentTerm_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMWorkOrderPaymentTerm_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMWorkOrderPaymentTerm_RPTFacade facade = context.Items["IPRMWorkOrderPaymentTerm_RPTFacade"] as Bay.ERP.BusinessFacade.IPRMWorkOrderPaymentTerm_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMWorkOrderPaymentTerm_RPTFacade();
                context.Items["IPRMWorkOrderPaymentTerm_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
