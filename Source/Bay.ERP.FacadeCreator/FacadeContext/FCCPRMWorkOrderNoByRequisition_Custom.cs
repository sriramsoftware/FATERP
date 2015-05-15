// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Dec-2012, 10:27:04




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMWorkOrderNoByRequisition_Custom
    {

        public FCCPRMWorkOrderNoByRequisition_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMWorkOrderNoByRequisition_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMWorkOrderNoByRequisition_CustomFacade facade = context.Items["IPRMWorkOrderNoByRequisition_CustomFacade"] as Bay.ERP.BusinessFacade.IPRMWorkOrderNoByRequisition_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMWorkOrderNoByRequisition_CustomFacade();
                context.Items["IPRMWorkOrderNoByRequisition_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
