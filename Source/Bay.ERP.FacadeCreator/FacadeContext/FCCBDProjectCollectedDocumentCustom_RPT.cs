// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jul-2013, 10:34:17




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDProjectCollectedDocumentCustom_RPT
    {

        public FCCBDProjectCollectedDocumentCustom_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProjectCollectedDocumentCustom_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProjectCollectedDocumentCustom_RPTFacade facade = context.Items["IBDProjectCollectedDocumentCustom_RPTFacade"] as Bay.ERP.BusinessFacade.IBDProjectCollectedDocumentCustom_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProjectCollectedDocumentCustom_RPTFacade();
                context.Items["IBDProjectCollectedDocumentCustom_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
