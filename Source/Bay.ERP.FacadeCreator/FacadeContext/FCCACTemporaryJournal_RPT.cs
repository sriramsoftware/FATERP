// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Feb-2013, 11:43:49




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACTemporaryJournal_RPT
    {

        public FCCACTemporaryJournal_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IACTemporaryJournal_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACTemporaryJournal_RPTFacade facade = context.Items["IACTemporaryJournal_RPTFacade"] as Bay.ERP.BusinessFacade.IACTemporaryJournal_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACTemporaryJournal_RPTFacade();
                context.Items["IACTemporaryJournal_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
