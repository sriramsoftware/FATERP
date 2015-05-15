// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Nov-2012, 10:07:19




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMWorkOrder_Detailed
    {

        public FCCPRMWorkOrder_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMWorkOrder_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMWorkOrder_DetailedFacade facade = context.Items["IPRMWorkOrder_DetailedFacade"] as Bay.ERP.BusinessFacade.IPRMWorkOrder_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMWorkOrder_DetailedFacade();
                context.Items["IPRMWorkOrder_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
