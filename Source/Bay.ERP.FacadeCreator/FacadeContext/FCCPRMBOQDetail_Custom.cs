// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-May-2012, 04:12:47




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMBOQDetail_Custom
    {

        public FCCPRMBOQDetail_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMBOQDetail_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMBOQDetail_CustomFacade facade = context.Items["IPRMBOQDetail_CustomFacade"] as Bay.ERP.BusinessFacade.IPRMBOQDetail_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMBOQDetail_CustomFacade();
                context.Items["IPRMBOQDetail_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
