// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Apr-2013, 04:34:01




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMBuyerBasicInfo_Detailed
    {

        public FCCCRMBuyerBasicInfo_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMBuyerBasicInfo_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMBuyerBasicInfo_DetailedFacade facade = context.Items["ICRMBuyerBasicInfo_DetailedFacade"] as Bay.ERP.BusinessFacade.ICRMBuyerBasicInfo_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMBuyerBasicInfo_DetailedFacade();
                context.Items["ICRMBuyerBasicInfo_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}