// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Feb-2013, 01:42:07




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACTemporaryJournalMaster_Detailed
    {

        public FCCACTemporaryJournalMaster_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IACTemporaryJournalMaster_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACTemporaryJournalMaster_DetailedFacade facade = context.Items["IACTemporaryJournalMaster_DetailedFacade"] as Bay.ERP.BusinessFacade.IACTemporaryJournalMaster_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACTemporaryJournalMaster_DetailedFacade();
                context.Items["IACTemporaryJournalMaster_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
