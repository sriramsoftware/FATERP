// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2013, 01:41:30




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMConsultant
    {

        public FCCCMConsultant()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMConsultantFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMConsultantFacade facade = context.Items["ICMConsultantFacade"] as Bay.ERP.BusinessFacade.ICMConsultantFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMConsultantFacade();
                context.Items["ICMConsultantFacade"] = facade;
            }
            return facade;
        }


    }
}
