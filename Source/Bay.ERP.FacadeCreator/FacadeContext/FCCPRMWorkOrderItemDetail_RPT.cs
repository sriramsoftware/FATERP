// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Oct-2012, 01:52:40




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMWorkOrderItemDetail_RPT
    {

        public FCCPRMWorkOrderItemDetail_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMWorkOrderItemDetail_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMWorkOrderItemDetail_RPTFacade facade = context.Items["IPRMWorkOrderItemDetail_RPTFacade"] as Bay.ERP.BusinessFacade.IPRMWorkOrderItemDetail_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMWorkOrderItemDetail_RPTFacade();
                context.Items["IPRMWorkOrderItemDetail_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
