// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jul-2013, 10:37:42




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACJournal_Detailed
    {

        public FCCACJournal_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IACJournal_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACJournal_DetailedFacade facade = context.Items["IACJournal_DetailedFacade"] as Bay.ERP.BusinessFacade.IACJournal_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACJournal_DetailedFacade();
                context.Items["IACJournal_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
