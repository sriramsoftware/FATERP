// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jun-2013, 02:07:00




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDProjectOtherInfo
    {

        public FCCBDProjectOtherInfo()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProjectOtherInfoFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProjectOtherInfoFacade facade = context.Items["IBDProjectOtherInfoFacade"] as Bay.ERP.BusinessFacade.IBDProjectOtherInfoFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProjectOtherInfoFacade();
                context.Items["IBDProjectOtherInfoFacade"] = facade;
            }
            return facade;
        }


    }
}
