// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Feb-2012, 11:55:12




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMConstructionTool_Detailed
    {

        public FCCCMConstructionTool_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMConstructionTool_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMConstructionTool_DetailedFacade facade = context.Items["ICMConstructionTool_DetailedFacade"] as Bay.ERP.BusinessFacade.ICMConstructionTool_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMConstructionTool_DetailedFacade();
                context.Items["ICMConstructionTool_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
