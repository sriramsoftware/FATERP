// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Jul-2012, 05:39:52




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMAdvertisementRequisition_RPT
    {

        public FCCCRMAdvertisementRequisition_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMAdvertisementRequisition_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMAdvertisementRequisition_RPTFacade facade = context.Items["ICRMAdvertisementRequisition_RPTFacade"] as Bay.ERP.BusinessFacade.ICRMAdvertisementRequisition_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMAdvertisementRequisition_RPTFacade();
                context.Items["ICRMAdvertisementRequisition_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
