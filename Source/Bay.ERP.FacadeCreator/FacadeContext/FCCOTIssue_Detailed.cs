// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Aug-2013, 01:22:41




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCOTIssue_Detailed
    {

        public FCCOTIssue_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IOTIssue_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IOTIssue_DetailedFacade facade = context.Items["IOTIssue_DetailedFacade"] as Bay.ERP.BusinessFacade.IOTIssue_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.OTIssue_DetailedFacade();
                context.Items["IOTIssue_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
