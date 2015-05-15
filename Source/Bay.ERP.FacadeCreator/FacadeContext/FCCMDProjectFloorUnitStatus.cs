// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 03:04:35




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDProjectFloorUnitStatus
    {

        public FCCMDProjectFloorUnitStatus()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDProjectFloorUnitStatusFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDProjectFloorUnitStatusFacade facade = context.Items["IMDProjectFloorUnitStatusFacade"] as Bay.ERP.BusinessFacade.IMDProjectFloorUnitStatusFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDProjectFloorUnitStatusFacade();
                context.Items["IMDProjectFloorUnitStatusFacade"] = facade;
            }
            return facade;
        }


    }
}
