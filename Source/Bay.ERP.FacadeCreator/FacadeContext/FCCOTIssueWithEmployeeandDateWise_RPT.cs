// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Jul-2013, 01:30:15




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCOTIssueWithEmployeeandDateWise_RPT
    {

        public FCCOTIssueWithEmployeeandDateWise_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IOTIssueWithEmployeeandDateWise_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IOTIssueWithEmployeeandDateWise_RPTFacade facade = context.Items["IOTIssueWithEmployeeandDateWise_RPTFacade"] as Bay.ERP.BusinessFacade.IOTIssueWithEmployeeandDateWise_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.OTIssueWithEmployeeandDateWise_RPTFacade();
                context.Items["IOTIssueWithEmployeeandDateWise_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
