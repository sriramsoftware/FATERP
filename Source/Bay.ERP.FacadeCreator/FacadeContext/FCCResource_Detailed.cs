// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Dec-2011, 05:48:38




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCResource_Detailed
    {

        public FCCResource_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IResource_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IResource_DetailedFacade facade = context.Items["IResource_DetailedFacade"] as Bay.ERP.BusinessFacade.IResource_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.Resource_DetailedFacade();
                context.Items["IResource_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
