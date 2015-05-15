// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Aug-2013, 03:30:14




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCREQRequisitionItemFloorDetail_RPT
    {

        public FCCREQRequisitionItemFloorDetail_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IREQRequisitionItemFloorDetail_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IREQRequisitionItemFloorDetail_RPTFacade facade = context.Items["IREQRequisitionItemFloorDetail_RPTFacade"] as Bay.ERP.BusinessFacade.IREQRequisitionItemFloorDetail_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.REQRequisitionItemFloorDetail_RPTFacade();
                context.Items["IREQRequisitionItemFloorDetail_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
