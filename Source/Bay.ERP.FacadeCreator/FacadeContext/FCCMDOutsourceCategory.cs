// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2013, 01:41:30




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDOutsourceCategory
    {

        public FCCMDOutsourceCategory()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDOutsourceCategoryFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDOutsourceCategoryFacade facade = context.Items["IMDOutsourceCategoryFacade"] as Bay.ERP.BusinessFacade.IMDOutsourceCategoryFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDOutsourceCategoryFacade();
                context.Items["IMDOutsourceCategoryFacade"] = facade;
            }
            return facade;
        }


    }
}
