// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2012, 04:17:30




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMPreBOQDetail_DetailedCustom
    {

        public FCCPRMPreBOQDetail_DetailedCustom()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMPreBOQDetail_DetailedCustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMPreBOQDetail_DetailedCustomFacade facade = context.Items["IPRMPreBOQDetail_DetailedCustomFacade"] as Bay.ERP.BusinessFacade.IPRMPreBOQDetail_DetailedCustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMPreBOQDetail_DetailedCustomFacade();
                context.Items["IPRMPreBOQDetail_DetailedCustomFacade"] = facade;
            }
            return facade;
        }


    }
}
