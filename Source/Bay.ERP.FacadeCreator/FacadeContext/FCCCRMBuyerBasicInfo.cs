// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-May-2013, 03:37:43




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMBuyerBasicInfo
    {

        public FCCCRMBuyerBasicInfo()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMBuyerBasicInfoFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMBuyerBasicInfoFacade facade = context.Items["ICRMBuyerBasicInfoFacade"] as Bay.ERP.BusinessFacade.ICRMBuyerBasicInfoFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMBuyerBasicInfoFacade();
                context.Items["ICRMBuyerBasicInfoFacade"] = facade;
            }
            return facade;
        }


    }
}
