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
    public class FCCCRMBuyerChildrenInfo
    {

        public FCCCRMBuyerChildrenInfo()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMBuyerChildrenInfoFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMBuyerChildrenInfoFacade facade = context.Items["ICRMBuyerChildrenInfoFacade"] as Bay.ERP.BusinessFacade.ICRMBuyerChildrenInfoFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMBuyerChildrenInfoFacade();
                context.Items["ICRMBuyerChildrenInfoFacade"] = facade;
            }
            return facade;
        }


    }
}
