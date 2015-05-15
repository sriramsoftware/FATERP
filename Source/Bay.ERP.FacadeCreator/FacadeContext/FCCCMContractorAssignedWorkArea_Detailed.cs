// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Nov-2012, 03:38:14




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMContractorAssignedWorkArea_Detailed
    {

        public FCCCMContractorAssignedWorkArea_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMContractorAssignedWorkArea_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMContractorAssignedWorkArea_DetailedFacade facade = context.Items["ICMContractorAssignedWorkArea_DetailedFacade"] as Bay.ERP.BusinessFacade.ICMContractorAssignedWorkArea_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMContractorAssignedWorkArea_DetailedFacade();
                context.Items["ICMContractorAssignedWorkArea_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
