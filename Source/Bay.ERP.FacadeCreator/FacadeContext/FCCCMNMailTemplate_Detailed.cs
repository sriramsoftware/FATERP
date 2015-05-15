// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Nov-2013, 10:24:45




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMNMailTemplate_Detailed
    {

        public FCCCMNMailTemplate_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMNMailTemplate_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMNMailTemplate_DetailedFacade facade = context.Items["ICMNMailTemplate_DetailedFacade"] as Bay.ERP.BusinessFacade.ICMNMailTemplate_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMNMailTemplate_DetailedFacade();
                context.Items["ICMNMailTemplate_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
