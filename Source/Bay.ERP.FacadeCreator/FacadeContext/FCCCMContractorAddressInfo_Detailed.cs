// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2012, 06:01:25




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMContractorAddressInfo_Detailed
    {

        public FCCCMContractorAddressInfo_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMContractorAddressInfo_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMContractorAddressInfo_DetailedFacade facade = context.Items["ICMContractorAddressInfo_DetailedFacade"] as Bay.ERP.BusinessFacade.ICMContractorAddressInfo_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMContractorAddressInfo_DetailedFacade();
                context.Items["ICMContractorAddressInfo_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
