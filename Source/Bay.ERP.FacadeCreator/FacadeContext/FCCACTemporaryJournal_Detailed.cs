// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Jul-2013, 01:34:19




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACTemporaryJournal_Detailed
    {

        public FCCACTemporaryJournal_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IACTemporaryJournal_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACTemporaryJournal_DetailedFacade facade = context.Items["IACTemporaryJournal_DetailedFacade"] as Bay.ERP.BusinessFacade.IACTemporaryJournal_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACTemporaryJournal_DetailedFacade();
                context.Items["IACTemporaryJournal_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
