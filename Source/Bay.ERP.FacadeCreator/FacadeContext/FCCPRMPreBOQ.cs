// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-May-2012, 04:19:57




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMPreBOQ
    {

        public FCCPRMPreBOQ()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMPreBOQFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMPreBOQFacade facade = context.Items["IPRMPreBOQFacade"] as Bay.ERP.BusinessFacade.IPRMPreBOQFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMPreBOQFacade();
                context.Items["IPRMPreBOQFacade"] = facade;
            }
            return facade;
        }


    }
}
