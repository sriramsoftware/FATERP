// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Feb-2012, 10:17:53




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMSupplierAddressInfo_Detailed
    {

        public FCCPRMSupplierAddressInfo_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMSupplierAddressInfo_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMSupplierAddressInfo_DetailedFacade facade = context.Items["IPRMSupplierAddressInfo_DetailedFacade"] as Bay.ERP.BusinessFacade.IPRMSupplierAddressInfo_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMSupplierAddressInfo_DetailedFacade();
                context.Items["IPRMSupplierAddressInfo_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
