// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDResourceCategory
    {

        public FCCMDResourceCategory()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDResourceCategoryFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDResourceCategoryFacade facade = context.Items["IMDResourceCategoryFacade"] as Bay.ERP.BusinessFacade.IMDResourceCategoryFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDResourceCategoryFacade();
                context.Items["IMDResourceCategoryFacade"] = facade;
            }
            return facade;
        }


    }
}
