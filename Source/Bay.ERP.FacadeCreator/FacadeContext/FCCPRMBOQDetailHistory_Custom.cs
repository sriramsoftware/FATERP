// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-May-2012, 10:19:19




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMBOQDetailHistory_Custom
    {

        public FCCPRMBOQDetailHistory_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMBOQDetailHistory_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMBOQDetailHistory_CustomFacade facade = context.Items["IPRMBOQDetailHistory_CustomFacade"] as Bay.ERP.BusinessFacade.IPRMBOQDetailHistory_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMBOQDetailHistory_CustomFacade();
                context.Items["IPRMBOQDetailHistory_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
