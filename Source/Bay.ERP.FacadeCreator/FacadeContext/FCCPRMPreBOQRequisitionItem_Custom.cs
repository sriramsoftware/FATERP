// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Oct-2012, 10:36:45




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMPreBOQRequisitionItem_Custom
    {

        public FCCPRMPreBOQRequisitionItem_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMPreBOQRequisitionItem_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMPreBOQRequisitionItem_CustomFacade facade = context.Items["IPRMPreBOQRequisitionItem_CustomFacade"] as Bay.ERP.BusinessFacade.IPRMPreBOQRequisitionItem_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMPreBOQRequisitionItem_CustomFacade();
                context.Items["IPRMPreBOQRequisitionItem_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
