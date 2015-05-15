// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMCriterionStatusRemarks
    {

        public FCCCMCriterionStatusRemarks()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMCriterionStatusRemarksFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMCriterionStatusRemarksFacade facade = context.Items["ICMCriterionStatusRemarksFacade"] as Bay.ERP.BusinessFacade.ICMCriterionStatusRemarksFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMCriterionStatusRemarksFacade();
                context.Items["ICMCriterionStatusRemarksFacade"] = facade;
            }
            return facade;
        }


    }
}
