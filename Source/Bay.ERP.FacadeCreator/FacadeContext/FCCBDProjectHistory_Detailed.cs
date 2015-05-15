// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-May-2012, 03:03:39




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDProjectHistory_Detailed
    {

        public FCCBDProjectHistory_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProjectHistory_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProjectHistory_DetailedFacade facade = context.Items["IBDProjectHistory_DetailedFacade"] as Bay.ERP.BusinessFacade.IBDProjectHistory_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProjectHistory_DetailedFacade();
                context.Items["IBDProjectHistory_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
