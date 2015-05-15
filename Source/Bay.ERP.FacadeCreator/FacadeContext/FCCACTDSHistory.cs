// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Mar-2013, 10:30:04




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACTDSHistory
    {

        public FCCACTDSHistory()
        {

        }

        public static Bay.ERP.BusinessFacade.IACTDSHistoryFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACTDSHistoryFacade facade = context.Items["IACTDSHistoryFacade"] as Bay.ERP.BusinessFacade.IACTDSHistoryFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACTDSHistoryFacade();
                context.Items["IACTDSHistoryFacade"] = facade;
            }
            return facade;
        }


    }
}
