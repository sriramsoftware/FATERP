// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Mar-2013, 05:35:27




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACMDTDSCategory
    {

        public FCCACMDTDSCategory()
        {

        }

        public static Bay.ERP.BusinessFacade.IACMDTDSCategoryFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACMDTDSCategoryFacade facade = context.Items["IACMDTDSCategoryFacade"] as Bay.ERP.BusinessFacade.IACMDTDSCategoryFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACMDTDSCategoryFacade();
                context.Items["IACMDTDSCategoryFacade"] = facade;
            }
            return facade;
        }


    }
}
