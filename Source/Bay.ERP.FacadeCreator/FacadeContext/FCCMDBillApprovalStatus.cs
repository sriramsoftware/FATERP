// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Oct-2012, 04:13:46




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDBillApprovalStatus
    {

        public FCCMDBillApprovalStatus()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDBillApprovalStatusFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDBillApprovalStatusFacade facade = context.Items["IMDBillApprovalStatusFacade"] as Bay.ERP.BusinessFacade.IMDBillApprovalStatusFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDBillApprovalStatusFacade();
                context.Items["IMDBillApprovalStatusFacade"] = facade;
            }
            return facade;
        }


    }
}
