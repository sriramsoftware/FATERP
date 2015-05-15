// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-May-2013, 03:57:32




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMPaymentCollectionMoneyRecipt_RPT
    {

        public FCCCRMPaymentCollectionMoneyRecipt_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMPaymentCollectionMoneyRecipt_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMPaymentCollectionMoneyRecipt_RPTFacade facade = context.Items["ICRMPaymentCollectionMoneyRecipt_RPTFacade"] as Bay.ERP.BusinessFacade.ICRMPaymentCollectionMoneyRecipt_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMPaymentCollectionMoneyRecipt_RPTFacade();
                context.Items["ICRMPaymentCollectionMoneyRecipt_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
