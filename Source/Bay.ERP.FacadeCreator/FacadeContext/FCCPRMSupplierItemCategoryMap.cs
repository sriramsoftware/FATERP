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
    public class FCCPRMSupplierItemCategoryMap
    {

        public FCCPRMSupplierItemCategoryMap()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMSupplierItemCategoryMapFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMSupplierItemCategoryMapFacade facade = context.Items["IPRMSupplierItemCategoryMapFacade"] as Bay.ERP.BusinessFacade.IPRMSupplierItemCategoryMapFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMSupplierItemCategoryMapFacade();
                context.Items["IPRMSupplierItemCategoryMapFacade"] = facade;
            }
            return facade;
        }


    }
}
