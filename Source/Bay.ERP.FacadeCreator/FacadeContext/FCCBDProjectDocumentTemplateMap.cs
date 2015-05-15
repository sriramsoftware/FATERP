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
    public class FCCBDProjectDocumentTemplateMap
    {

        public FCCBDProjectDocumentTemplateMap()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProjectDocumentTemplateMapFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProjectDocumentTemplateMapFacade facade = context.Items["IBDProjectDocumentTemplateMapFacade"] as Bay.ERP.BusinessFacade.IBDProjectDocumentTemplateMapFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProjectDocumentTemplateMapFacade();
                context.Items["IBDProjectDocumentTemplateMapFacade"] = facade;
            }
            return facade;
        }


    }
}
