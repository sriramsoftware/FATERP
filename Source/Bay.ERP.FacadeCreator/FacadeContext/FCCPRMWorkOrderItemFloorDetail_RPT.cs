// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Aug-2013, 02:00:59




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMWorkOrderItemFloorDetail_RPT
    {

        public FCCPRMWorkOrderItemFloorDetail_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMWorkOrderItemFloorDetail_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMWorkOrderItemFloorDetail_RPTFacade facade = context.Items["IPRMWorkOrderItemFloorDetail_RPTFacade"] as Bay.ERP.BusinessFacade.IPRMWorkOrderItemFloorDetail_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMWorkOrderItemFloorDetail_RPTFacade();
                context.Items["IPRMWorkOrderItemFloorDetail_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
