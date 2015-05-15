// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Nov-2013, 10:23:55




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCREQRequisitionItemFloorDetail
    {

        public FCCREQRequisitionItemFloorDetail()
        {

        }

        public static Bay.ERP.BusinessFacade.IREQRequisitionItemFloorDetailFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IREQRequisitionItemFloorDetailFacade facade = context.Items["IREQRequisitionItemFloorDetailFacade"] as Bay.ERP.BusinessFacade.IREQRequisitionItemFloorDetailFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.REQRequisitionItemFloorDetailFacade();
                context.Items["IREQRequisitionItemFloorDetailFacade"] = facade;
            }
            return facade;
        }


    }
}
