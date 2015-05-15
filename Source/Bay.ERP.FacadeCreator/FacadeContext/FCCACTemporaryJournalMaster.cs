// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Feb-2013, 12:00:20




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACTemporaryJournalMaster
    {

        public FCCACTemporaryJournalMaster()
        {

        }

        public static Bay.ERP.BusinessFacade.IACTemporaryJournalMasterFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACTemporaryJournalMasterFacade facade = context.Items["IACTemporaryJournalMasterFacade"] as Bay.ERP.BusinessFacade.IACTemporaryJournalMasterFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACTemporaryJournalMasterFacade();
                context.Items["IACTemporaryJournalMasterFacade"] = facade;
            }
            return facade;
        }


    }
}
