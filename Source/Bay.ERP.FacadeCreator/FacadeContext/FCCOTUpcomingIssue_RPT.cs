// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-May-2012, 05:15:27




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCOTUpcomingIssue_RPT
    {

        public FCCOTUpcomingIssue_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IOTUpcomingIssue_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IOTUpcomingIssue_RPTFacade facade = context.Items["IOTUpcomingIssue_RPTFacade"] as Bay.ERP.BusinessFacade.IOTUpcomingIssue_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.OTUpcomingIssue_RPTFacade();
                context.Items["IOTUpcomingIssue_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
