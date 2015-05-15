// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Aug-2013, 05:17:44




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMMaterialReceiveItemMap_Detailed
    {

        public FCCPRMMaterialReceiveItemMap_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMMaterialReceiveItemMap_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMMaterialReceiveItemMap_DetailedFacade facade = context.Items["IPRMMaterialReceiveItemMap_DetailedFacade"] as Bay.ERP.BusinessFacade.IPRMMaterialReceiveItemMap_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMMaterialReceiveItemMap_DetailedFacade();
                context.Items["IPRMMaterialReceiveItemMap_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
