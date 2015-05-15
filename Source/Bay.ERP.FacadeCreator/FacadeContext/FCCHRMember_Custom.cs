// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Jul-2012, 04:33:32




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHRMember_Custom
    {

        public FCCHRMember_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IHRMember_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHRMember_CustomFacade facade = context.Items["IHRMember_CustomFacade"] as Bay.ERP.BusinessFacade.IHRMember_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HRMember_CustomFacade();
                context.Items["IHRMember_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
