// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2012, 01:28:24




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMPreBOQDetail_Custom
    {

        public FCCPRMPreBOQDetail_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMPreBOQDetail_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMPreBOQDetail_CustomFacade facade = context.Items["IPRMPreBOQDetail_CustomFacade"] as Bay.ERP.BusinessFacade.IPRMPreBOQDetail_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMPreBOQDetail_CustomFacade();
                context.Items["IPRMPreBOQDetail_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
