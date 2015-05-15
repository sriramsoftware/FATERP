// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Jan-2014, 02:53:23




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDLeaveCategory
    {

        public FCCMDLeaveCategory()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDLeaveCategoryFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDLeaveCategoryFacade facade = context.Items["IMDLeaveCategoryFacade"] as Bay.ERP.BusinessFacade.IMDLeaveCategoryFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDLeaveCategoryFacade();
                context.Items["IMDLeaveCategoryFacade"] = facade;
            }
            return facade;
        }


    }
}
