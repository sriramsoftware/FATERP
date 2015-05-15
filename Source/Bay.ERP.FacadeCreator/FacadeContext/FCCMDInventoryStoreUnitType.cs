// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 02:18:05




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDInventoryStoreUnitType
    {

        public FCCMDInventoryStoreUnitType()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDInventoryStoreUnitTypeFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDInventoryStoreUnitTypeFacade facade = context.Items["IMDInventoryStoreUnitTypeFacade"] as Bay.ERP.BusinessFacade.IMDInventoryStoreUnitTypeFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDInventoryStoreUnitTypeFacade();
                context.Items["IMDInventoryStoreUnitTypeFacade"] = facade;
            }
            return facade;
        }


    }
}
