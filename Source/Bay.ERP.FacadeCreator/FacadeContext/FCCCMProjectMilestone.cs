// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jan-2012, 04:09:33




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMProjectMilestone
    {

        public FCCCMProjectMilestone()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMProjectMilestoneFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMProjectMilestoneFacade facade = context.Items["ICMProjectMilestoneFacade"] as Bay.ERP.BusinessFacade.ICMProjectMilestoneFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMProjectMilestoneFacade();
                context.Items["ICMProjectMilestoneFacade"] = facade;
            }
            return facade;
        }


    }
}
