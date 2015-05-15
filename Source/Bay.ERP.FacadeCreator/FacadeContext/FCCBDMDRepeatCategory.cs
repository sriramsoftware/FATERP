// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDMDRepeatCategory
    {

        public FCCBDMDRepeatCategory()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDMDRepeatCategoryFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDMDRepeatCategoryFacade facade = context.Items["IBDMDRepeatCategoryFacade"] as Bay.ERP.BusinessFacade.IBDMDRepeatCategoryFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDMDRepeatCategoryFacade();
                context.Items["IBDMDRepeatCategoryFacade"] = facade;
            }
            return facade;
        }


    }
}
