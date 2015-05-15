// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-May-2012, 12:37:41




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMConsultantEnlistedWorkArea_Custom
    {

        public FCCCMConsultantEnlistedWorkArea_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMConsultantEnlistedWorkArea_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMConsultantEnlistedWorkArea_CustomFacade facade = context.Items["ICMConsultantEnlistedWorkArea_CustomFacade"] as Bay.ERP.BusinessFacade.ICMConsultantEnlistedWorkArea_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMConsultantEnlistedWorkArea_CustomFacade();
                context.Items["ICMConsultantEnlistedWorkArea_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
