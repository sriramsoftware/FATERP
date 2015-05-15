// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Feb-2012, 05:41:59




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMSupplierAddressInfo
    {

        public FCCPRMSupplierAddressInfo()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMSupplierAddressInfoFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMSupplierAddressInfoFacade facade = context.Items["IPRMSupplierAddressInfoFacade"] as Bay.ERP.BusinessFacade.IPRMSupplierAddressInfoFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMSupplierAddressInfoFacade();
                context.Items["IPRMSupplierAddressInfoFacade"] = facade;
            }
            return facade;
        }


    }
}
