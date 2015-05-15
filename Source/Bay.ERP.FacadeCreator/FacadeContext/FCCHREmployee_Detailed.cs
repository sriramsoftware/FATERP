// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Dec-2013, 11:16:35




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployee_Detailed
    {

        public FCCHREmployee_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployee_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployee_DetailedFacade facade = context.Items["IHREmployee_DetailedFacade"] as Bay.ERP.BusinessFacade.IHREmployee_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployee_DetailedFacade();
                context.Items["IHREmployee_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
