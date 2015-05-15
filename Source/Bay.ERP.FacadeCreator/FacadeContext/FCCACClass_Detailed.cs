// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2013, 05:23:47




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACClass_Detailed
    {

        public FCCACClass_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IACClass_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACClass_DetailedFacade facade = context.Items["IACClass_DetailedFacade"] as Bay.ERP.BusinessFacade.IACClass_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACClass_DetailedFacade();
                context.Items["IACClass_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
