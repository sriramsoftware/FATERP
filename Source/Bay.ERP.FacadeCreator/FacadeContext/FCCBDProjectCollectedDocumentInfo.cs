// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDProjectCollectedDocumentInfo
    {

        public FCCBDProjectCollectedDocumentInfo()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProjectCollectedDocumentInfoFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProjectCollectedDocumentInfoFacade facade = context.Items["IBDProjectCollectedDocumentInfoFacade"] as Bay.ERP.BusinessFacade.IBDProjectCollectedDocumentInfoFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProjectCollectedDocumentInfoFacade();
                context.Items["IBDProjectCollectedDocumentInfoFacade"] = facade;
            }
            return facade;
        }


    }
}
