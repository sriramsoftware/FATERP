// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Dec-2012, 08:03:28




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDVendorCategory
    {

        public FCCMDVendorCategory()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDVendorCategoryFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDVendorCategoryFacade facade = context.Items["IMDVendorCategoryFacade"] as Bay.ERP.BusinessFacade.IMDVendorCategoryFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDVendorCategoryFacade();
                context.Items["IMDVendorCategoryFacade"] = facade;
            }
            return facade;
        }


    }
}
