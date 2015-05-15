// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-May-2012, 11:02:33




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMSupplierBrandMap
    {

        public FCCPRMSupplierBrandMap()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMSupplierBrandMapFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMSupplierBrandMapFacade facade = context.Items["IPRMSupplierBrandMapFacade"] as Bay.ERP.BusinessFacade.IPRMSupplierBrandMapFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMSupplierBrandMapFacade();
                context.Items["IPRMSupplierBrandMapFacade"] = facade;
            }
            return facade;
        }


    }
}
