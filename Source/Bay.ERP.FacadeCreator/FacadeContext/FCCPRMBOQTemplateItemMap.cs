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
    public class FCCPRMBOQTemplateItemMap
    {

        public FCCPRMBOQTemplateItemMap()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMBOQTemplateItemMapFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMBOQTemplateItemMapFacade facade = context.Items["IPRMBOQTemplateItemMapFacade"] as Bay.ERP.BusinessFacade.IPRMBOQTemplateItemMapFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMBOQTemplateItemMapFacade();
                context.Items["IPRMBOQTemplateItemMapFacade"] = facade;
            }
            return facade;
        }


    }
}
