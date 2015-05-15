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
    public class FCCPRMBOQDetailHistory
    {

        public FCCPRMBOQDetailHistory()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMBOQDetailHistoryFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMBOQDetailHistoryFacade facade = context.Items["IPRMBOQDetailHistoryFacade"] as Bay.ERP.BusinessFacade.IPRMBOQDetailHistoryFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMBOQDetailHistoryFacade();
                context.Items["IPRMBOQDetailHistoryFacade"] = facade;
            }
            return facade;
        }


    }
}