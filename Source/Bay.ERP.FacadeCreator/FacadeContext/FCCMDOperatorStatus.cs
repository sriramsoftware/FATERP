// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2015, 12:41:19




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDOperatorStatus
    {

        public FCCMDOperatorStatus()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDOperatorStatusFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDOperatorStatusFacade facade = context.Items["IMDOperatorStatusFacade"] as Bay.ERP.BusinessFacade.IMDOperatorStatusFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDOperatorStatusFacade();
                context.Items["IMDOperatorStatusFacade"] = facade;
            }
            return facade;
        }


    }
}
