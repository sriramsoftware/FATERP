// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Jan-2012, 02:37:47




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMProjectMilestone_Custom
    {

        public FCCCMProjectMilestone_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMProjectMilestone_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMProjectMilestone_CustomFacade facade = context.Items["ICMProjectMilestone_CustomFacade"] as Bay.ERP.BusinessFacade.ICMProjectMilestone_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMProjectMilestone_CustomFacade();
                context.Items["ICMProjectMilestone_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
