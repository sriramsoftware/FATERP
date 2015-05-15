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
    public class FCCPRMWorkOrder_RPT
    {

        public FCCPRMWorkOrder_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMWorkOrder_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMWorkOrder_RPTFacade facade = context.Items["IPRMWorkOrder_RPTFacade"] as Bay.ERP.BusinessFacade.IPRMWorkOrder_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMWorkOrder_RPTFacade();
                context.Items["IPRMWorkOrder_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
