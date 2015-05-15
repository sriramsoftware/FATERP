// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Dec-2011, 05:48:38




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDScheduleCategory_Detailed
    {

        public FCCMDScheduleCategory_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDScheduleCategory_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDScheduleCategory_DetailedFacade facade = context.Items["IMDScheduleCategory_DetailedFacade"] as Bay.ERP.BusinessFacade.IMDScheduleCategory_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDScheduleCategory_DetailedFacade();
                context.Items["IMDScheduleCategory_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
