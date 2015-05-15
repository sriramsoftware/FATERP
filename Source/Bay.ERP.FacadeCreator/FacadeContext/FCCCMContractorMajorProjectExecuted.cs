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
    public class FCCCMContractorMajorProjectExecuted
    {

        public FCCCMContractorMajorProjectExecuted()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMContractorMajorProjectExecutedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMContractorMajorProjectExecutedFacade facade = context.Items["ICMContractorMajorProjectExecutedFacade"] as Bay.ERP.BusinessFacade.ICMContractorMajorProjectExecutedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMContractorMajorProjectExecutedFacade();
                context.Items["ICMContractorMajorProjectExecutedFacade"] = facade;
            }
            return facade;
        }


    }
}
