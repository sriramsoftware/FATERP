// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Jan-2012, 03:42:46




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMPreBOQTemplateItemMapBulkInsert
    {

        public FCCPRMPreBOQTemplateItemMapBulkInsert()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMPreBOQTemplateItemMapBulkInsertFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMPreBOQTemplateItemMapBulkInsertFacade facade = context.Items["IPRMPreBOQTemplateItemMapBulkInsertFacade"] as Bay.ERP.BusinessFacade.IPRMPreBOQTemplateItemMapBulkInsertFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMPreBOQTemplateItemMapBulkInsertFacade();
                context.Items["IPRMPreBOQTemplateItemMapBulkInsertFacade"] = facade;
            }
            return facade;
        }


    }
}
