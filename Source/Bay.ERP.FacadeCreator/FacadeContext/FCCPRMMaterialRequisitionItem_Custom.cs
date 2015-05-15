// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Feb-2013, 06:05:18




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMMaterialRequisitionItem_Custom
    {

        public FCCPRMMaterialRequisitionItem_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMMaterialRequisitionItem_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMMaterialRequisitionItem_CustomFacade facade = context.Items["IPRMMaterialRequisitionItem_CustomFacade"] as Bay.ERP.BusinessFacade.IPRMMaterialRequisitionItem_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMMaterialRequisitionItem_CustomFacade();
                context.Items["IPRMMaterialRequisitionItem_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
