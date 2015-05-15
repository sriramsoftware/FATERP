// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Jul-2012, 03:56:56




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMWorkOrderByRequisitionDistinct_Custom
    {

        public FCCPRMWorkOrderByRequisitionDistinct_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMWorkOrderByRequisitionDistinct_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMWorkOrderByRequisitionDistinct_CustomFacade facade = context.Items["IPRMWorkOrderByRequisitionDistinct_CustomFacade"] as Bay.ERP.BusinessFacade.IPRMWorkOrderByRequisitionDistinct_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMWorkOrderByRequisitionDistinct_CustomFacade();
                context.Items["IPRMWorkOrderByRequisitionDistinct_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
