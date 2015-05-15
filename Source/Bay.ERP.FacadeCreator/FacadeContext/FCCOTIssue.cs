// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Aug-2013, 04:20:37




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCOTIssue
    {

        public FCCOTIssue()
        {

        }

        public static Bay.ERP.BusinessFacade.IOTIssueFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IOTIssueFacade facade = context.Items["IOTIssueFacade"] as Bay.ERP.BusinessFacade.IOTIssueFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.OTIssueFacade();
                context.Items["IOTIssueFacade"] = facade;
            }
            return facade;
        }


    }
}
