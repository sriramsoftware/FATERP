// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Jul-2012, 03:56:56




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMSupplierByProjectDistinct_Custom
    {

        public FCCPRMSupplierByProjectDistinct_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMSupplierByProjectDistinct_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMSupplierByProjectDistinct_CustomFacade facade = context.Items["IPRMSupplierByProjectDistinct_CustomFacade"] as Bay.ERP.BusinessFacade.IPRMSupplierByProjectDistinct_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMSupplierByProjectDistinct_CustomFacade();
                context.Items["IPRMSupplierByProjectDistinct_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
