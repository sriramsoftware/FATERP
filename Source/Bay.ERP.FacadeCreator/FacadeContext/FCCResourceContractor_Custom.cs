// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Feb-2012, 11:07:17




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCResourceContractor_Custom
    {

        public FCCResourceContractor_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IResourceContractor_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IResourceContractor_CustomFacade facade = context.Items["IResourceContractor_CustomFacade"] as Bay.ERP.BusinessFacade.IResourceContractor_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ResourceContractor_CustomFacade();
                context.Items["IResourceContractor_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
