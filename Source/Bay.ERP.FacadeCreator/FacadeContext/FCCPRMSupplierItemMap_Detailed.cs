// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Apr-2012, 11:14:21




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMSupplierItemMap_Detailed
    {

        public FCCPRMSupplierItemMap_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMSupplierItemMap_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMSupplierItemMap_DetailedFacade facade = context.Items["IPRMSupplierItemMap_DetailedFacade"] as Bay.ERP.BusinessFacade.IPRMSupplierItemMap_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMSupplierItemMap_DetailedFacade();
                context.Items["IPRMSupplierItemMap_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
