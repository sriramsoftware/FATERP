// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-May-2013, 04:56:23




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMBookingStatus_RPT
    {

        public FCCCRMBookingStatus_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMBookingStatus_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMBookingStatus_RPTFacade facade = context.Items["ICRMBookingStatus_RPTFacade"] as Bay.ERP.BusinessFacade.ICRMBookingStatus_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMBookingStatus_RPTFacade();
                context.Items["ICRMBookingStatus_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
