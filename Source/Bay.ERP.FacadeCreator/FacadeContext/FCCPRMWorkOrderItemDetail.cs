// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Sep-2012, 04:57:13




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMWorkOrderItemDetail
    {

        public FCCPRMWorkOrderItemDetail()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMWorkOrderItemDetailFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMWorkOrderItemDetailFacade facade = context.Items["IPRMWorkOrderItemDetailFacade"] as Bay.ERP.BusinessFacade.IPRMWorkOrderItemDetailFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMWorkOrderItemDetailFacade();
                context.Items["IPRMWorkOrderItemDetailFacade"] = facade;
            }
            return facade;
        }


    }
}
