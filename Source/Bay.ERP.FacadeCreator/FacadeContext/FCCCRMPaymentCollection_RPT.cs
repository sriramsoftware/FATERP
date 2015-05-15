// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-May-2013, 01:17:08




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMPaymentCollection_RPT
    {

        public FCCCRMPaymentCollection_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMPaymentCollection_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMPaymentCollection_RPTFacade facade = context.Items["ICRMPaymentCollection_RPTFacade"] as Bay.ERP.BusinessFacade.ICRMPaymentCollection_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMPaymentCollection_RPTFacade();
                context.Items["ICRMPaymentCollection_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
