// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Jun-2012, 10:26:50




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMContractorAssignedWorkArea
    {

        public FCCCMContractorAssignedWorkArea()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMContractorAssignedWorkAreaFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMContractorAssignedWorkAreaFacade facade = context.Items["ICMContractorAssignedWorkAreaFacade"] as Bay.ERP.BusinessFacade.ICMContractorAssignedWorkAreaFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMContractorAssignedWorkAreaFacade();
                context.Items["ICMContractorAssignedWorkAreaFacade"] = facade;
            }
            return facade;
        }


    }
}
