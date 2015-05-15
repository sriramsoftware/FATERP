// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Jun-2013, 04:42:43




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCREQRequisitionDashboard_Custom
    {

        public FCCREQRequisitionDashboard_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IREQRequisitionDashboard_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IREQRequisitionDashboard_CustomFacade facade = context.Items["IREQRequisitionDashboard_CustomFacade"] as Bay.ERP.BusinessFacade.IREQRequisitionDashboard_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.REQRequisitionDashboard_CustomFacade();
                context.Items["IREQRequisitionDashboard_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
