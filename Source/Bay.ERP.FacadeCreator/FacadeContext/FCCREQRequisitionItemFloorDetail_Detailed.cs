// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Aug-2013, 01:37:35




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCREQRequisitionItemFloorDetail_Detailed
    {

        public FCCREQRequisitionItemFloorDetail_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IREQRequisitionItemFloorDetail_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IREQRequisitionItemFloorDetail_DetailedFacade facade = context.Items["IREQRequisitionItemFloorDetail_DetailedFacade"] as Bay.ERP.BusinessFacade.IREQRequisitionItemFloorDetail_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.REQRequisitionItemFloorDetail_DetailedFacade();
                context.Items["IREQRequisitionItemFloorDetail_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
