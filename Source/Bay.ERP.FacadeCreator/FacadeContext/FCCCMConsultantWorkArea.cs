// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 04:47:08




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMConsultantWorkArea
    {

        public FCCCMConsultantWorkArea()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMConsultantWorkAreaFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMConsultantWorkAreaFacade facade = context.Items["ICMConsultantWorkAreaFacade"] as Bay.ERP.BusinessFacade.ICMConsultantWorkAreaFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMConsultantWorkAreaFacade();
                context.Items["ICMConsultantWorkAreaFacade"] = facade;
            }
            return facade;
        }


    }
}
