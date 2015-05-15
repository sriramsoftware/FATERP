// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jul-2012, 02:14:35




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDProjectByMember_Custom
    {

        public FCCBDProjectByMember_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProjectByMember_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProjectByMember_CustomFacade facade = context.Items["IBDProjectByMember_CustomFacade"] as Bay.ERP.BusinessFacade.IBDProjectByMember_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProjectByMember_CustomFacade();
                context.Items["IBDProjectByMember_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
