// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Jan-2012, 01:23:18




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMConsultantEnlistedWorkArea
    {

        public FCCCMConsultantEnlistedWorkArea()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMConsultantEnlistedWorkAreaFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMConsultantEnlistedWorkAreaFacade facade = context.Items["ICMConsultantEnlistedWorkAreaFacade"] as Bay.ERP.BusinessFacade.ICMConsultantEnlistedWorkAreaFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMConsultantEnlistedWorkAreaFacade();
                context.Items["ICMConsultantEnlistedWorkAreaFacade"] = facade;
            }
            return facade;
        }


    }
}
