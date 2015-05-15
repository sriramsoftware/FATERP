// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Sep-2013, 02:31:14




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMWorkOrderSingleClickFromRequisition_Custom
    {

        public FCCPRMWorkOrderSingleClickFromRequisition_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMWorkOrderSingleClickFromRequisition_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMWorkOrderSingleClickFromRequisition_CustomFacade facade = context.Items["IPRMWorkOrderSingleClickFromRequisition_CustomFacade"] as Bay.ERP.BusinessFacade.IPRMWorkOrderSingleClickFromRequisition_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMWorkOrderSingleClickFromRequisition_CustomFacade();
                context.Items["IPRMWorkOrderSingleClickFromRequisition_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
