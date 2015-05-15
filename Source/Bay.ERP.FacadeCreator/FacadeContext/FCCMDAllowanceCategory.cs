// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Jan-2014, 11:30:08




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDAllowanceCategory
    {

        public FCCMDAllowanceCategory()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDAllowanceCategoryFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDAllowanceCategoryFacade facade = context.Items["IMDAllowanceCategoryFacade"] as Bay.ERP.BusinessFacade.IMDAllowanceCategoryFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDAllowanceCategoryFacade();
                context.Items["IMDAllowanceCategoryFacade"] = facade;
            }
            return facade;
        }


    }
}
