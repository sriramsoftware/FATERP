// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Jul-2013, 10:18:14




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCActivityLog
    {

        public FCCActivityLog()
        {

        }

        public static Bay.ERP.BusinessFacade.IActivityLogFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IActivityLogFacade facade = context.Items["IActivityLogFacade"] as Bay.ERP.BusinessFacade.IActivityLogFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ActivityLogFacade();
                context.Items["IActivityLogFacade"] = facade;
            }
            return facade;
        }


    }
}
