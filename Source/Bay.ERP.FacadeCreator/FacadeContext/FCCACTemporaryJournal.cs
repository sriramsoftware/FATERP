// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Jul-2013, 11:20:53




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACTemporaryJournal
    {

        public FCCACTemporaryJournal()
        {

        }

        public static Bay.ERP.BusinessFacade.IACTemporaryJournalFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACTemporaryJournalFacade facade = context.Items["IACTemporaryJournalFacade"] as Bay.ERP.BusinessFacade.IACTemporaryJournalFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACTemporaryJournalFacade();
                context.Items["IACTemporaryJournalFacade"] = facade;
            }
            return facade;
        }


    }
}
