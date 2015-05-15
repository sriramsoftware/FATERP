// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Apr-2012, 03:22:36




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMSupplierByBrand_Custom
    {

        public FCCPRMSupplierByBrand_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMSupplierByBrand_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMSupplierByBrand_CustomFacade facade = context.Items["IPRMSupplierByBrand_CustomFacade"] as Bay.ERP.BusinessFacade.IPRMSupplierByBrand_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMSupplierByBrand_CustomFacade();
                context.Items["IPRMSupplierByBrand_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
