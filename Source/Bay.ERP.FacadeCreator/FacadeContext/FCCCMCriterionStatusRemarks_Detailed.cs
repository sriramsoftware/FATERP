// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Mar-2012, 11:54:12




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMCriterionStatusRemarks_Detailed
    {

        public FCCCMCriterionStatusRemarks_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMCriterionStatusRemarks_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMCriterionStatusRemarks_DetailedFacade facade = context.Items["ICMCriterionStatusRemarks_DetailedFacade"] as Bay.ERP.BusinessFacade.ICMCriterionStatusRemarks_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMCriterionStatusRemarks_DetailedFacade();
                context.Items["ICMCriterionStatusRemarks_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
