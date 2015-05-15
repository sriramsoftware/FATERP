// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Mar-2013, 10:27:29




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACMDBankAccountTransferApprovalStatus
    {

        public FCCACMDBankAccountTransferApprovalStatus()
        {

        }

        public static Bay.ERP.BusinessFacade.IACMDBankAccountTransferApprovalStatusFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACMDBankAccountTransferApprovalStatusFacade facade = context.Items["IACMDBankAccountTransferApprovalStatusFacade"] as Bay.ERP.BusinessFacade.IACMDBankAccountTransferApprovalStatusFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACMDBankAccountTransferApprovalStatusFacade();
                context.Items["IACMDBankAccountTransferApprovalStatusFacade"] = facade;
            }
            return facade;
        }


    }
}
