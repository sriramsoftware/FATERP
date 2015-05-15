// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Aug-2013, 10:45:50




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCOTIssueCategoryWise_RPT
    {

        public FCCOTIssueCategoryWise_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IOTIssueCategoryWise_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IOTIssueCategoryWise_RPTFacade facade = context.Items["IOTIssueCategoryWise_RPTFacade"] as Bay.ERP.BusinessFacade.IOTIssueCategoryWise_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.OTIssueCategoryWise_RPTFacade();
                context.Items["IOTIssueCategoryWise_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
