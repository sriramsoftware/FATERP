// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jan-2012, 04:26:55




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMProjectMilestone_Detailed
    {

        public FCCCMProjectMilestone_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMProjectMilestone_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMProjectMilestone_DetailedFacade facade = context.Items["ICMProjectMilestone_DetailedFacade"] as Bay.ERP.BusinessFacade.ICMProjectMilestone_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMProjectMilestone_DetailedFacade();
                context.Items["ICMProjectMilestone_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
