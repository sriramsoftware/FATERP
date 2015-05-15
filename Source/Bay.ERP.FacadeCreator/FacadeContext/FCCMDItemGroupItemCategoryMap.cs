// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDItemGroupItemCategoryMap
    {

        public FCCMDItemGroupItemCategoryMap()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDItemGroupItemCategoryMapFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDItemGroupItemCategoryMapFacade facade = context.Items["IMDItemGroupItemCategoryMapFacade"] as Bay.ERP.BusinessFacade.IMDItemGroupItemCategoryMapFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDItemGroupItemCategoryMapFacade();
                context.Items["IMDItemGroupItemCategoryMapFacade"] = facade;
            }
            return facade;
        }


    }
}
