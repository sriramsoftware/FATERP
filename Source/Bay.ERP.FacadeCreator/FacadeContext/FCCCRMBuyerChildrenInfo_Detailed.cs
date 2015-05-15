// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2013, 05:23:47




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMBuyerChildrenInfo_Detailed
    {

        public FCCCRMBuyerChildrenInfo_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMBuyerChildrenInfo_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMBuyerChildrenInfo_DetailedFacade facade = context.Items["ICRMBuyerChildrenInfo_DetailedFacade"] as Bay.ERP.BusinessFacade.ICRMBuyerChildrenInfo_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMBuyerChildrenInfo_DetailedFacade();
                context.Items["ICRMBuyerChildrenInfo_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
