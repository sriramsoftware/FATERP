// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-May-2013, 01:39:36




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMPaymentEncashed_RPT
    {

        public FCCCRMPaymentEncashed_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMPaymentEncashed_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMPaymentEncashed_RPTFacade facade = context.Items["ICRMPaymentEncashed_RPTFacade"] as Bay.ERP.BusinessFacade.ICRMPaymentEncashed_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMPaymentEncashed_RPTFacade();
                context.Items["ICRMPaymentEncashed_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
