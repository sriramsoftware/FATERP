// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Jan-2013, 10:51:15




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCREQRequisitionWithWorkOrder_Custom
    {

        public FCCREQRequisitionWithWorkOrder_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IREQRequisitionWithWorkOrder_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IREQRequisitionWithWorkOrder_CustomFacade facade = context.Items["IREQRequisitionWithWorkOrder_CustomFacade"] as Bay.ERP.BusinessFacade.IREQRequisitionWithWorkOrder_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.REQRequisitionWithWorkOrder_CustomFacade();
                context.Items["IREQRequisitionWithWorkOrder_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
