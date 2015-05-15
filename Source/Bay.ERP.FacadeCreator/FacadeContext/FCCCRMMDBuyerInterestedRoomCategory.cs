// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMMDBuyerInterestedRoomCategory
    {

        public FCCCRMMDBuyerInterestedRoomCategory()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMMDBuyerInterestedRoomCategoryFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMMDBuyerInterestedRoomCategoryFacade facade = context.Items["ICRMMDBuyerInterestedRoomCategoryFacade"] as Bay.ERP.BusinessFacade.ICRMMDBuyerInterestedRoomCategoryFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMMDBuyerInterestedRoomCategoryFacade();
                context.Items["ICRMMDBuyerInterestedRoomCategoryFacade"] = facade;
            }
            return facade;
        }


    }
}
