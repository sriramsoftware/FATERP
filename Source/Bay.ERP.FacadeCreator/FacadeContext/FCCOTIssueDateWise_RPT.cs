// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Jul-2013, 10:44:57




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCOTIssueDateWise_RPT
    {

        public FCCOTIssueDateWise_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IOTIssueDateWise_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IOTIssueDateWise_RPTFacade facade = context.Items["IOTIssueDateWise_RPTFacade"] as Bay.ERP.BusinessFacade.IOTIssueDateWise_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.OTIssueDateWise_RPTFacade();
                context.Items["IOTIssueDateWise_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}