// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Aug-2013, 03:52:52




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCOTIssueCategoryWiseIndividual_RPT
    {

        public FCCOTIssueCategoryWiseIndividual_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IOTIssueCategoryWiseIndividual_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IOTIssueCategoryWiseIndividual_RPTFacade facade = context.Items["IOTIssueCategoryWiseIndividual_RPTFacade"] as Bay.ERP.BusinessFacade.IOTIssueCategoryWiseIndividual_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.OTIssueCategoryWiseIndividual_RPTFacade();
                context.Items["IOTIssueCategoryWiseIndividual_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
