// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 04:47:08




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMConsultantAddressInfo
    {

        public FCCCMConsultantAddressInfo()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMConsultantAddressInfoFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMConsultantAddressInfoFacade facade = context.Items["ICMConsultantAddressInfoFacade"] as Bay.ERP.BusinessFacade.ICMConsultantAddressInfoFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMConsultantAddressInfoFacade();
                context.Items["ICMConsultantAddressInfoFacade"] = facade;
            }
            return facade;
        }


    }
}