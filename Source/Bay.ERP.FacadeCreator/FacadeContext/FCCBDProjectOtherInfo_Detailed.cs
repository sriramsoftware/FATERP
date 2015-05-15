// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Dec-2011, 02:17:33




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDProjectOtherInfo_Detailed
    {

        public FCCBDProjectOtherInfo_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProjectOtherInfo_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProjectOtherInfo_DetailedFacade facade = context.Items["IBDProjectOtherInfo_DetailedFacade"] as Bay.ERP.BusinessFacade.IBDProjectOtherInfo_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProjectOtherInfo_DetailedFacade();
                context.Items["IBDProjectOtherInfo_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
