// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jul-2013, 02:22:23




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACCashPaymentDateWise_RPT
    {

        public FCCACCashPaymentDateWise_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IACCashPaymentDateWise_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACCashPaymentDateWise_RPTFacade facade = context.Items["IACCashPaymentDateWise_RPTFacade"] as Bay.ERP.BusinessFacade.IACCashPaymentDateWise_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACCashPaymentDateWise_RPTFacade();
                context.Items["IACCashPaymentDateWise_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
