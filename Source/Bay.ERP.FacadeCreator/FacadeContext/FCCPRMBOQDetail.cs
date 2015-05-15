// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMBOQDetail
    {

        public FCCPRMBOQDetail()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMBOQDetailFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMBOQDetailFacade facade = context.Items["IPRMBOQDetailFacade"] as Bay.ERP.BusinessFacade.IPRMBOQDetailFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMBOQDetailFacade();
                context.Items["IPRMBOQDetailFacade"] = facade;
            }
            return facade;
        }


    }
}
