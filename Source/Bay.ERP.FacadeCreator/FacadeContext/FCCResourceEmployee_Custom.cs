// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Feb-2012, 10:12:12




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCResourceEmployee_Custom
    {

        public FCCResourceEmployee_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IResourceEmployee_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IResourceEmployee_CustomFacade facade = context.Items["IResourceEmployee_CustomFacade"] as Bay.ERP.BusinessFacade.IResourceEmployee_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ResourceEmployee_CustomFacade();
                context.Items["IResourceEmployee_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
