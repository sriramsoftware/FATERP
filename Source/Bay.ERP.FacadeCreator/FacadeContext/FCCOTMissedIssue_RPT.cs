// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-May-2012, 11:08:03




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCOTMissedIssue_RPT
    {

        public FCCOTMissedIssue_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IOTMissedIssue_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IOTMissedIssue_RPTFacade facade = context.Items["IOTMissedIssue_RPTFacade"] as Bay.ERP.BusinessFacade.IOTMissedIssue_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.OTMissedIssue_RPTFacade();
                context.Items["IOTMissedIssue_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
