// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Oct-2012, 01:09:23




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMBOQRequisitionItem_Custom
    {

        public FCCPRMBOQRequisitionItem_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMBOQRequisitionItem_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMBOQRequisitionItem_CustomFacade facade = context.Items["IPRMBOQRequisitionItem_CustomFacade"] as Bay.ERP.BusinessFacade.IPRMBOQRequisitionItem_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMBOQRequisitionItem_CustomFacade();
                context.Items["IPRMBOQRequisitionItem_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
