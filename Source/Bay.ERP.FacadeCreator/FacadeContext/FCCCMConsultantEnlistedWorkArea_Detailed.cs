// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Jan-2012, 01:42:10




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMConsultantEnlistedWorkArea_Detailed
    {

        public FCCCMConsultantEnlistedWorkArea_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMConsultantEnlistedWorkArea_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMConsultantEnlistedWorkArea_DetailedFacade facade = context.Items["ICMConsultantEnlistedWorkArea_DetailedFacade"] as Bay.ERP.BusinessFacade.ICMConsultantEnlistedWorkArea_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMConsultantEnlistedWorkArea_DetailedFacade();
                context.Items["ICMConsultantEnlistedWorkArea_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
