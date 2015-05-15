// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Jul-2013, 05:44:25




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMAvailableBOQQtyForRequisition
    {

        public FCCPRMAvailableBOQQtyForRequisition()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMAvailableBOQQtyForRequisitionFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMAvailableBOQQtyForRequisitionFacade facade = context.Items["IPRMAvailableBOQQtyForRequisitionFacade"] as Bay.ERP.BusinessFacade.IPRMAvailableBOQQtyForRequisitionFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMAvailableBOQQtyForRequisitionFacade();
                context.Items["IPRMAvailableBOQQtyForRequisitionFacade"] = facade;
            }
            return facade;
        }


    }
}
