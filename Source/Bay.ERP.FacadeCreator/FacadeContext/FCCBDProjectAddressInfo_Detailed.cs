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
    public class FCCBDProjectAddressInfo_Detailed
    {

        public FCCBDProjectAddressInfo_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProjectAddressInfo_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProjectAddressInfo_DetailedFacade facade = context.Items["IBDProjectAddressInfo_DetailedFacade"] as Bay.ERP.BusinessFacade.IBDProjectAddressInfo_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProjectAddressInfo_DetailedFacade();
                context.Items["IBDProjectAddressInfo_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
