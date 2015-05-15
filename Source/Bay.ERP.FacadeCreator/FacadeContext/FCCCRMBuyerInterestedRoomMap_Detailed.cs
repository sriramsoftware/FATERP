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
    public class FCCCRMBuyerInterestedRoomMap_Detailed
    {

        public FCCCRMBuyerInterestedRoomMap_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMBuyerInterestedRoomMap_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMBuyerInterestedRoomMap_DetailedFacade facade = context.Items["ICRMBuyerInterestedRoomMap_DetailedFacade"] as Bay.ERP.BusinessFacade.ICRMBuyerInterestedRoomMap_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMBuyerInterestedRoomMap_DetailedFacade();
                context.Items["ICRMBuyerInterestedRoomMap_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
