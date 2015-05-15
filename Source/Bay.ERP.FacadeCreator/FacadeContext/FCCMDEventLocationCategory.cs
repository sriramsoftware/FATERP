// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Oct-2013, 02:28:24




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDEventLocationCategory
    {

        public FCCMDEventLocationCategory()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDEventLocationCategoryFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDEventLocationCategoryFacade facade = context.Items["IMDEventLocationCategoryFacade"] as Bay.ERP.BusinessFacade.IMDEventLocationCategoryFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDEventLocationCategoryFacade();
                context.Items["IMDEventLocationCategoryFacade"] = facade;
            }
            return facade;
        }


    }
}
