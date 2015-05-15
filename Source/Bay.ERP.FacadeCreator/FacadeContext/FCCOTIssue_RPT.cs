// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Jun-2012, 12:03:16




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCOTIssue_RPT
    {

        public FCCOTIssue_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IOTIssue_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IOTIssue_RPTFacade facade = context.Items["IOTIssue_RPTFacade"] as Bay.ERP.BusinessFacade.IOTIssue_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.OTIssue_RPTFacade();
                context.Items["IOTIssue_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
