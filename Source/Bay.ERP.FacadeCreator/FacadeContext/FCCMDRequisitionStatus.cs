// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jan-2012, 10:20:36




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDRequisitionStatus
    {

        public FCCMDRequisitionStatus()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDRequisitionStatusFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDRequisitionStatusFacade facade = context.Items["IMDRequisitionStatusFacade"] as Bay.ERP.BusinessFacade.IMDRequisitionStatusFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDRequisitionStatusFacade();
                context.Items["IMDRequisitionStatusFacade"] = facade;
            }
            return facade;
        }


    }
}
