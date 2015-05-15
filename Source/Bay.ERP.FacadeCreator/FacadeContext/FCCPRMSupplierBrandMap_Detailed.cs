// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-May-2012, 02:11:24




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMSupplierBrandMap_Detailed
    {

        public FCCPRMSupplierBrandMap_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMSupplierBrandMap_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMSupplierBrandMap_DetailedFacade facade = context.Items["IPRMSupplierBrandMap_DetailedFacade"] as Bay.ERP.BusinessFacade.IPRMSupplierBrandMap_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMSupplierBrandMap_DetailedFacade();
                context.Items["IPRMSupplierBrandMap_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
