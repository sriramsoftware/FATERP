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
    public class FCCCMContractor
    {

        public FCCCMContractor()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMContractorFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMContractorFacade facade = context.Items["ICMContractorFacade"] as Bay.ERP.BusinessFacade.ICMContractorFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMContractorFacade();
                context.Items["ICMContractorFacade"] = facade;
            }
            return facade;
        }


    }
}
