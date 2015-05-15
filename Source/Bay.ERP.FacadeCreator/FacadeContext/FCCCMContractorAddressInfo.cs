// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2012, 02:49:42




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMContractorAddressInfo
    {

        public FCCCMContractorAddressInfo()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMContractorAddressInfoFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMContractorAddressInfoFacade facade = context.Items["ICMContractorAddressInfoFacade"] as Bay.ERP.BusinessFacade.ICMContractorAddressInfoFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMContractorAddressInfoFacade();
                context.Items["ICMContractorAddressInfoFacade"] = facade;
            }
            return facade;
        }


    }
}
