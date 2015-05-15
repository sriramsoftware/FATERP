// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Sep-2012, 11:06:52




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMPreBOQDetailHistory
    {

        public FCCPRMPreBOQDetailHistory()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMPreBOQDetailHistoryFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMPreBOQDetailHistoryFacade facade = context.Items["IPRMPreBOQDetailHistoryFacade"] as Bay.ERP.BusinessFacade.IPRMPreBOQDetailHistoryFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMPreBOQDetailHistoryFacade();
                context.Items["IPRMPreBOQDetailHistoryFacade"] = facade;
            }
            return facade;
        }


    }
}
