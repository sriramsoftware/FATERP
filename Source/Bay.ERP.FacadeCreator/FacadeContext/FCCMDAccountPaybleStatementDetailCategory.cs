// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 11:43:49




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDAccountPaybleStatementDetailCategory
    {

        public FCCMDAccountPaybleStatementDetailCategory()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDAccountPaybleStatementDetailCategoryFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDAccountPaybleStatementDetailCategoryFacade facade = context.Items["IMDAccountPaybleStatementDetailCategoryFacade"] as Bay.ERP.BusinessFacade.IMDAccountPaybleStatementDetailCategoryFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDAccountPaybleStatementDetailCategoryFacade();
                context.Items["IMDAccountPaybleStatementDetailCategoryFacade"] = facade;
            }
            return facade;
        }


    }
}
