// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Oct-2012, 11:18:20




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMWorkOrderItemByWorkOrder_Custom
    {

        public FCCPRMWorkOrderItemByWorkOrder_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMWorkOrderItemByWorkOrder_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMWorkOrderItemByWorkOrder_CustomFacade facade = context.Items["IPRMWorkOrderItemByWorkOrder_CustomFacade"] as Bay.ERP.BusinessFacade.IPRMWorkOrderItemByWorkOrder_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMWorkOrderItemByWorkOrder_CustomFacade();
                context.Items["IPRMWorkOrderItemByWorkOrder_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
