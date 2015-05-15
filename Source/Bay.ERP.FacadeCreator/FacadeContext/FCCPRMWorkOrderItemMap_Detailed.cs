// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Sep-2013, 02:13:02




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMWorkOrderItemMap_Detailed
    {

        public FCCPRMWorkOrderItemMap_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMWorkOrderItemMap_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMWorkOrderItemMap_DetailedFacade facade = context.Items["IPRMWorkOrderItemMap_DetailedFacade"] as Bay.ERP.BusinessFacade.IPRMWorkOrderItemMap_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMWorkOrderItemMap_DetailedFacade();
                context.Items["IPRMWorkOrderItemMap_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
