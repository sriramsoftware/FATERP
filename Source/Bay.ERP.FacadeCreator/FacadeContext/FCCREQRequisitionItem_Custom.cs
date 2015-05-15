// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jun-2012, 10:09:58




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCREQRequisitionItem_Custom
    {

        public FCCREQRequisitionItem_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IREQRequisitionItem_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IREQRequisitionItem_CustomFacade facade = context.Items["IREQRequisitionItem_CustomFacade"] as Bay.ERP.BusinessFacade.IREQRequisitionItem_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.REQRequisitionItem_CustomFacade();
                context.Items["IREQRequisitionItem_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
