// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Dec-2012, 01:46:09




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDInventoryTransferStatus
    {

        public FCCMDInventoryTransferStatus()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDInventoryTransferStatusFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDInventoryTransferStatusFacade facade = context.Items["IMDInventoryTransferStatusFacade"] as Bay.ERP.BusinessFacade.IMDInventoryTransferStatusFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDInventoryTransferStatusFacade();
                context.Items["IMDInventoryTransferStatusFacade"] = facade;
            }
            return facade;
        }


    }
}
